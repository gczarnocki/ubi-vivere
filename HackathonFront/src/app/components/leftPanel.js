angular.module('app.components')
  .component('leftPanel', {
    templateUrl: 'app/components/leftPanel.html',
    controller: LeftPanelCtrl,
    controllerAs: 'lp'
  });

function LeftPanelCtrl(preferencesProvider) {
  var vm = this;

  // 0 - preset
  // 1 - manual (advanced)
  vm.mode = 0;
  vm.preferencesP = preferencesProvider;
  vm.selectedProfile = null;
  vm.toggleMode = toggleMode;

  function toggleMode() {
    vm.mode = !vm.mode;
  };


  return vm;
}
