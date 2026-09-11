// Small client-side helpers for static (SSR) pages — no Blazor circuit needed.
window.caeUi = {
  // toggle a password input between hidden/visible text (eye icon button)
  togglePw: function (btn) {
    var wrap = btn.closest('.pw-wrap') || btn.parentElement;
    var input = wrap ? wrap.querySelector('input') : null;
    if (!input) return;
    var show = input.type === 'password';
    input.type = show ? 'text' : 'password';
    btn.textContent = show ? '🙈' : '👁';
    btn.setAttribute('aria-label', show ? 'Hide password' : 'Show password');
  }
};
