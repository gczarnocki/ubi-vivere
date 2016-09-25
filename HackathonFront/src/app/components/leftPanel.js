angular.module('app.components')
  .component('leftPanel', {
    templateUrl: 'app/components/leftPanel.html',
    controller: LeftPanelCtrl,
    controllerAs: 'lp'
  });

function LeftPanelCtrl() {
  var vm = this;

  // 0 - preset
  // 1 - manual (advanced)
  vm.mode = 0;
  vm.preferences = [
      {
          id:"PRZ",
          name:"Przedszkole",
          radius: 0,
          weigh: 0
      }, {
          id:"SP",
          name:"Szkoła podstawowa",
          radius: 0,
          weigh: 0
      }, {
          id:"GIM",
          name:"Gimnazjum",
          radius: 0,
          weigh: 0
      }, {
          id:"LIC",
          name:"Liceum",
          radius: 0,
          weigh: 0
      }
  ];
  vm.selectedProfile = null;
  vm.toggleMode = toggleMode;

  function toggleMode() {
    vm.mode = !vm.mode;
  };


  return vm;
}
