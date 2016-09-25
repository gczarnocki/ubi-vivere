angular.module('app.components')
  .component('profileSelector', {
    templateUrl: 'app/components/profileSelector.html',
    controller: ProfileSelectorCtrl,
    controllerAs: 'profileSelector',
    bindings: {
      mode: '='
    }
  });

function ProfileSelectorCtrl (constants, preferencesProvider) {
  var vm = this;
  vm.selectedProfile = null;
  vm.toggleMode = toggleMode;
  vm.preferences = preferencesProvider.preferences;
  vm.profiles = constants.profiles;

  vm.selectProfile = function(id) {
    preferencesProvider.preferences = constants.profiles[id].preferences;
    console.log(preferencesProvider.preferences);
    vm.selectedProfile = constants.profiles[id];
    vm.toggleMode();
  };

  function toggleMode() {
    vm.mode = !vm.mode;
  };

  return vm;
}
