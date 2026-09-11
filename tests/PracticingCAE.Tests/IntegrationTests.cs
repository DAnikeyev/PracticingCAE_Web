using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Net.Http;
using Xunit;

namespace PracticingCAE.Tests;

/// <summary>
/// End-to-end HTTP tests over the real app: auth, redirects, antiforgery and
/// error handling. Uses a throwaway SQLite database per factory.
/// </summary>
public class IntegrationTests : IClassFixture<IntegrationTests.TestApp>
{
    public sealed class TestApp : WebApplicationFactory<Program>
    {
        public string DataDir { get; } =
            Path.Combine(Path.GetTempPath(), "cae-test-" + Guid.NewGuid().ToString("N"));

        public TestApp()
        {
            Environment.SetEnvironmentVariable("DATA_DIR", DataDir);
            // force client to NOT follow redirects so we can assert them
            ClientOptions.AllowAutoRedirect = false;
            _ = Server; // trigger host creation; migrations run on first request anyway
        }

        public HttpClient CreateCookieClient()
        {
            var client = CreateDefaultClient(new CookieCaptureHandler());
            return client;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            try { if (Directory.Exists(DataDir)) Directory.Delete(DataDir, recursive: true); } catch { }
        }
    }

    /// <summary>Keeps Set-Cookie cookies and replays them on subsequent requests.</summary>
    private sealed class CookieCaptureHandler : DelegatingHandler
    {
        private readonly Dictionary<string, string> _cookies = new();

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (_cookies.Count > 0)
                request.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", _cookies.Select(c => $"{c.Key}={c.Value}")));

            var response = await base.SendAsync(request, cancellationToken);
            if (response.Headers.TryGetValues("Set-Cookie", out var setCookies))
            {
                foreach (var header in setCookies.ToList())
                {
                    var pair = header.Split(';').First().Split('=', 2);
                    if (pair.Length == 2)
                    {
                        if (pair[1].Length == 0 || header.Contains("Expires=Thu, 01 Jan 1970"))
                            _cookies.Remove(pair[0].Trim());
                        else
                            _cookies[pair[0].Trim()] = pair[1];
                    }
                }
            }
            return response;
        }
    }

    private readonly TestApp _factory;

    public IntegrationTests(TestApp factory) => _factory = factory;

    private static string? ExtractAntiForgeryToken(string html)
    {
        var idx = html.IndexOf("__RequestVerificationToken", StringComparison.Ordinal);
        if (idx < 0) return null;
        var valueIdx = html.IndexOf("value=\"", idx, StringComparison.Ordinal);
        if (valueIdx < 0) return null;
        var start = valueIdx + "value=\"".Length;
        var end = html.IndexOf('"', start);
        return html[start..end];
    }

    private static async Task<HttpResponseMessage> PostFormAsync(
        HttpClient client, string url, Dictionary<string, string> fields)
    {
        var response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
        var html = await response.Content.ReadAsStringAsync();

        // replay every hidden input of the rendered form (handler dispatch, tokens, return urls)
        foreach (System.Text.RegularExpressions.Match m in
                 System.Text.RegularExpressions.Regex.Matches(
                     html, "<input[^>]*type=\"hidden\"[^>]*>").Cast<System.Text.RegularExpressions.Match>())
        {
            var tag = m.Value;
            var name = System.Text.RegularExpressions.Regex.Match(tag, "name=\"([^\"]+)\"").Groups[1].Value;
            var value = System.Text.RegularExpressions.Regex.Match(tag, "value=\"([^\"]*)\"").Groups[1].Value;
            if (name.Length > 0 && !fields.ContainsKey(name))
                fields[name] = value;
        }

        var token = ExtractAntiForgeryToken(html)
            ?? throw new InvalidOperationException("no antiforgery token on page " + url);
        fields["__RequestVerificationToken"] = token;
        return await client.PostAsync(url, new FormUrlEncodedContent(fields));
    }

    [Fact]
    public async Task Home_Returns200_WithBlazorBootstrap()
    {
        var client = _factory.CreateClient();
        var response = await client.GetAsync("/");
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var html = await response.Content.ReadAsStringAsync();
        Assert.Contains("blazor.web.js", html);
    }

    [Fact]
    public async Task UnknownPage_Returns404()
    {
        var client = _factory.CreateClient();
        var response = await client.GetAsync("/this-page-does-not-exist");
        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }

    [Fact]
    public async Task Practice_UnknownTask_Returns200()
    {
        var client = _factory.CreateClient();
        var response = await client.GetAsync("/practice/no-such-task");
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task Progress_Anonymous_Returns200()
    {
        var client = _factory.CreateClient();
        var response = await client.GetAsync("/progress");
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task Register_Get_ReturnsForm_WithoutExampleEmail()
    {
        var client = _factory.CreateCookieClient();
        var response = await client.GetAsync("/Account/Register");
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var html = await response.Content.ReadAsStringAsync();
        Assert.Contains("Register", html);
        Assert.DoesNotContain("name@example.com", html);
        Assert.Contains("__RequestVerificationToken", html);
    }

    [Fact]
    public async Task AccountManage_WhenAnonymous_RedirectsToLogin()
    {
        var client = _factory.CreateClient();
        var response = await client.GetAsync("/Account/Manage");
        Assert.Equal(HttpStatusCode.Redirect, response.StatusCode);
        var location = response.Headers.Location?.ToString() ?? "";
        Assert.Contains("Account/Login", location);
        Assert.Contains("ReturnUrl", location);
    }

    [Fact]
    public async Task Logout_PostWithoutAntiforgery_IsRejected()
    {
        var client = _factory.CreateClient();
        var response = await client.PostAsync("/Account/Logout", new FormUrlEncodedContent(
            new Dictionary<string, string> { ["ReturnUrl"] = "" }));
        Assert.True(response.StatusCode is HttpStatusCode.BadRequest,
            $"expected 400, got {response.StatusCode}");
    }

    [Fact]
    public async Task Register_WithShortPassword_ShowsValidationError()
    {
        var client = _factory.CreateCookieClient();
        var response = await PostFormAsync(client, "/Account/Register", new Dictionary<string, string>
        {
            ["Input.Email"] = "shortpw@example.com",
            ["Input.Password"] = "123",
            ["Input.ConfirmPassword"] = "123",
        });
        var html = await response.Content.ReadAsStringAsync();
        if (response.StatusCode != HttpStatusCode.OK)
            throw new Exception("POST status " + response.StatusCode + " body: " + html.Substring(0, Math.Min(700, html.Length)));
        Assert.Matches("at least 6", html);
    }

    [Fact]
    public async Task Register_Login_Logout_FullFlow()
    {
        var client = _factory.CreateCookieClient();
        var email = $"flow-{Guid.NewGuid():N}@example.com";

        // register: with RequireConfirmedAccount=false the user is signed in and redirected
        var register = await PostFormAsync(client, "/Account/Register", new Dictionary<string, string>
        {
            ["Input.Email"] = email,
            ["Input.Password"] = "CorrectHorse1",
            ["Input.ConfirmPassword"] = "CorrectHorse1",
        });
        Assert.True(register.StatusCode is HttpStatusCode.Redirect or HttpStatusCode.OK,
            $"register returned {register.StatusCode}");
        var manage = await client.GetAsync("/Account/Manage");
        var manageHtml = await manage.Content.ReadAsStringAsync();
        Assert.Equal(HttpStatusCode.OK, manage.StatusCode);
        Assert.Contains(email, manageHtml); // signed in as the new user

        // log out: the logout form posts with an antiforgery token
        var home = await client.GetAsync("/Account/Manage");
        var homeHtml = await home.Content.ReadAsStringAsync();
        var token = ExtractAntiForgeryToken(homeHtml)
            ?? throw new InvalidOperationException("no antiforgery token on manage page");
        var logout = await client.PostAsync("/Account/Logout", new FormUrlEncodedContent(
            new Dictionary<string, string> { ["__RequestVerificationToken"] = token, ["ReturnUrl"] = "" }));
        Assert.True(logout.StatusCode is HttpStatusCode.Redirect or HttpStatusCode.OK,
            $"logout returned {logout.StatusCode}");

        // after logout, manage requires login again
        var manageAfter = await client.GetAsync("/Account/Manage");
        Assert.Equal(HttpStatusCode.Redirect, manageAfter.StatusCode);
    }

    [Fact]
    public async Task Login_WithWrongPassword_ShowsError_AndDoesNotAuthenticate()
    {
        var client = _factory.CreateCookieClient();
        var email = $"wrongpw-{Guid.NewGuid():N}@example.com";

        // create the user through the register form
        await PostFormAsync(client, "/Account/Register", new Dictionary<string, string>
        {
            ["Input.Email"] = email,
            ["Input.Password"] = "CorrectHorse1",
            ["Input.ConfirmPassword"] = "CorrectHorse1",
        });
        // log out (session from registration) without antiforgery fails, so use a fresh client
        var fresh = _factory.CreateCookieClient();

        var login = await PostFormAsync(fresh, "/Account/Login", new Dictionary<string, string>
        {
            ["Input.Email"] = email,
            ["Input.Password"] = "DefinitelyWrong1",
        });
        Assert.Equal(HttpStatusCode.OK, login.StatusCode);
        var html = await login.Content.ReadAsStringAsync();
        Assert.Contains("Invalid login attempt", html);

        // no authenticated cookie was issued
        var manage = await fresh.GetAsync("/Account/Manage");
        Assert.Equal(HttpStatusCode.Redirect, manage.StatusCode);
    }

    [Fact]
    public async Task Login_WithCorrectPassword_Authenticates()
    {
        var client = _factory.CreateCookieClient();
        var email = $"login-{Guid.NewGuid():N}@example.com";
        await PostFormAsync(client, "/Account/Register", new Dictionary<string, string>
        {
            ["Input.Email"] = email,
            ["Input.Password"] = "Simple6",
            ["Input.ConfirmPassword"] = "Simple6",
        });

        var fresh = _factory.CreateCookieClient();
        var login = await PostFormAsync(fresh, "/Account/Login", new Dictionary<string, string>
        {
            ["Input.Email"] = email,
            ["Input.Password"] = "Simple6", // simple password: no special characters required
        });
        Assert.True(login.StatusCode is HttpStatusCode.Redirect or HttpStatusCode.OK,
            $"login returned {login.StatusCode}");
        var manage = await fresh.GetAsync("/Account/Manage");
        Assert.Equal(HttpStatusCode.OK, manage.StatusCode);
    }

    [Fact]
    public async Task ForgotPassword_Page_Returns200()
    {
        var client = _factory.CreateClient();
        var response = await client.GetAsync("/Account/ForgotPassword");
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}
