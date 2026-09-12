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
  },

  // tiny typed preference store
  getPref: function (key, fallback) {
    try {
      var raw = localStorage.getItem('cae_pref_' + key);
      return raw === null ? fallback : JSON.parse(raw);
    } catch (e) { return fallback; }
  },
  setPref: function (key, value) {
    try { localStorage.setItem('cae_pref_' + key, JSON.stringify(value)); } catch (e) { }
  },

  // fill the gap inputs with provided answers (used after switching answer mode)
  fillGapInputs: function (answers) {
    var inputs = document.querySelectorAll('.gap-list input.gap-input');
    for (var i = 0; i < inputs.length; i++) {
      var v = answers && answers[i] ? answers[i] : '';
      if (v) inputs[i].value = v;
    }
  },

  // focus the first answer input on the page
  focusFirstGap: function () {
    var input = document.querySelector('.gap-list input.gap-input');
    if (input) input.focus();
  }
};

// Enter moves to the next gap input; from the last one, focus the Check button.
document.addEventListener('keydown', function (e) {
  if (e.key !== 'Enter') return;
  var target = e.target;
  if (!target || target.tagName !== 'INPUT' || !target.closest('.gap-list')) return;
  e.preventDefault();
  var inputs = Array.prototype.slice.call(document.querySelectorAll('.gap-list input.gap-input'));
  var i = inputs.indexOf(target);
  if (i >= 0 && i < inputs.length - 1) {
    inputs[i + 1].focus();
  } else {
    var check = Array.prototype.find.call(document.querySelectorAll('button'), function (b) {
      return b.textContent.indexOf('Check') !== -1 && !b.disabled;
    });
    if (check) check.focus();
  }
});
