// Anonymous owner id: lets logged-out visitors keep progress in this browser and
// have it adopted into their account when they register or log in.
window.caeOwner = {
  getOrCreateAnonId: function () {
    try {
      var v = localStorage.getItem('cae_anon_owner');
      if (!v) {
        v = (crypto && crypto.randomUUID) ? crypto.randomUUID() : (Date.now() + '-' + Math.random().toString(16).slice(2));
        localStorage.setItem('cae_anon_owner', v);
      }
      return v;
    } catch (e) {
      // localStorage unavailable (private mode etc.) — fall back to a per-page-load id
      return window.caeOwner.__fallback || (window.caeOwner.__fallback = 'ephemeral-' + Math.random().toString(16).slice(2));
    }
  }
};
