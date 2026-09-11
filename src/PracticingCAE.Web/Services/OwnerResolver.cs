using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using System.Security.Claims;

namespace PracticingCAE.Web.Services;

/// <summary>
/// Resolves the "owner" progress is filed under: the logged-in user, or — until they
/// register/login — an anonymous id kept in the browser's localStorage. When an anonymous
/// visitor logs in, their history is adopted into their account.
/// </summary>
public sealed class OwnerResolver(
    AuthenticationStateProvider authState,
    ProgressService progress,
    OwnerJsInterop js)
{
    private string? _cached;

    public async Task<string> GetOwnerIdAsync()
    {
        if (_cached is not null) return _cached;

        var state = await authState.GetAuthenticationStateAsync();
        var user = state.User;
        if (user.Identity?.IsAuthenticated == true)
        {
            var userId = user.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!string.IsNullOrEmpty(userId))
            {
                var owner = $"u:{userId}";
                _cached = owner;
                // merge this browser's anonymous history in (no-op when there is none)
                try
                {
                    var anon = await js.GetOrCreateAnonIdAsync();
                    if (!string.IsNullOrEmpty(anon))
                        await progress.AdoptAnonymousAsync($"a:{anon}", owner);
                }
                catch (JSUnavailableException)
                {
                    // prerender or disconnected circuit — adoption retried on next render
                }
                return owner;
            }
        }

        var id = await js.GetOrCreateAnonIdAsync();
        _cached = $"a:{id}";
        return _cached;
    }
}

/// <summary>Thin wrapper over window.caeOwner defined in wwwroot/js/owner.js.</summary>
public sealed class OwnerJsInterop(IJSRuntime js)
{
    public async Task<string> GetOrCreateAnonIdAsync()
    {
        var id = await js.InvokeAsync<string?>("caeOwner.getOrCreateAnonId");
        return id ?? Guid.NewGuid().ToString("N");
    }
}

/// <summary>Thrown by JS interop when no JS runtime is available (static prerender).</summary>
public sealed class JSUnavailableException : Exception
{
    public JSUnavailableException() : base("JS runtime unavailable") { }
}
