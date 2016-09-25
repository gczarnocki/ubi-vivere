angular.module('app.components')
  .component('profileSelector', {
    templateUrl: 'app/components/profileSelector.html',
    controller: ProfileSelectorCtrl,
    controllerAs: 'profileSelector',
    bindings: {
      onSelect: '&',
      mode: '='
    }
  });

function ProfileSelectorCtrl (constants) {
  var vm = this;
  vm.selectedProfile = null;
  vm.toggleMode = toggleMode;

  vm.profiles = constants.profiles;

  vm.selectProfile = function(id) {
    vm.selectedProfile = vm.profiles[id];
    vm.onSelect(vm.selectedProfile);
  };

  function toggleMode() {
    vm.mode = !vm.mode;
  };

  return vm;
}
