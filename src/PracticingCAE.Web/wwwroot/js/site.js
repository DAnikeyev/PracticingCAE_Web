// Small client-side helpers for static (SSR) pages — no Blazor circuit needed.
window.caeUi = {
  // toggle a password input between hidden/visible text (eye icon button)
  togglePw: function (btn) {
    var wrap = btn.closest('.pw-wrap') || btn.parentElement;
    var input = wrap ? wrap.querySelector('input') : null;
    if (!input) return;
    var show = input.type === 'password';
    input.type = show ? 'text' : 'password';
    btn.textContent = show ? 'Hide' : 'Show';
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
  },

  // ---- in-progress practice session (survives reconnects and page reloads) ----
  practiceKey: function (taskId) { return 'cae_practice_' + taskId; },

  // id of this real page load: survives Blazor reconnects, changes on reload/navigation
  ensurePageInstance: function () {
    if (!window.__caePageInstance) {
      try { window.__caePageInstance = crypto.randomUUID(); }
      catch (e) { window.__caePageInstance = 'pi-' + Date.now() + '-' + Math.random().toString(36).slice(2); }
    }
    return window.__caePageInstance;
  },

  getPracticeSession: function (taskId) {
    try {
      var raw = localStorage.getItem(this.practiceKey(taskId));
      return raw ? JSON.parse(raw) : null;
    } catch (e) { return null; }
  },

  savePracticeSession: function (taskId, record) {
    var self = this;
    clearTimeout(self._psTimer);
    self._psTimer = setTimeout(function () {
      try {
        record.pageInstance = self.ensurePageInstance();
        localStorage.setItem(self.practiceKey(taskId), JSON.stringify(record));
      } catch (e) { }
    }, 200);
  },

  clearPracticeSession: function (taskId) {
    clearTimeout(this._psTimer);
    try { localStorage.removeItem(this.practiceKey(taskId)); } catch (e) { }
  },

  // Restore the saved set when the circuit came back or the page was reloaded;
  // start fresh when the page was reached by deliberate navigation.
  shouldRestorePractice: function (taskId) {
    var s = this.getPracticeSession(taskId);
    if (!s) return false;
    var nav = (window.performance && performance.getEntriesByType)
      ? performance.getEntriesByType('navigation')[0] : null;
    var type = nav ? nav.type : 'navigate';
    if (type === 'reload' || type === 'back_forward') return true;
    return !!s.pageInstance && s.pageInstance === this.ensurePageInstance();
  }
};

// Clicking a task card on the home page deliberately starts a new set:
// drop any saved in-progress session for that task. (Capture phase, so it
// runs before Blazor's enhanced navigation handles the link.)
document.addEventListener('click', function (e) {
  var a = e.target && e.target.closest ? e.target.closest('a.task-card') : null;
  if (!a) return;
  var m = (a.getAttribute('href') || '').match(/\/practice\/([^/?#]+)/);
  if (m) {
    clearTimeout(window.caeUi._psTimer);
    try { localStorage.removeItem('cae_practice_' + decodeURIComponent(m[1])); } catch (err) { }
  }
}, true);

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
