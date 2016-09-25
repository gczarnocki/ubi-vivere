angular.module('app.components')
  .component('preferencesForm', {
    templateUrl: 'app/components/preferencesForm.html',
    controller: PreferencesFormCtrl,
    bindings: {
      value: '<'
    }
  })

function PreferencesFormCtrl () {
  var vm = this;
  vm.preferences = [
      {
          id:"PRZ",
          name:"Przedszkole",
          isSwitchOn:false,
          radius: 250,
          weigh: 1
      }, {
          id:"SP",
          name:"Szkoła podstawowa",
          isSwitchOn:false,
          radius: 250,
          weigh: 1
      }, {
          id:"GIM",
          name:"Gimnazjum",
          isSwitchOn:false,
          radius: 250,
          weigh: 1
      }, {
          id:"LIC",
          name:"Liceum",
          isSwitchOn:false,
          radius: 250,
          weigh: 1
      }
  ];

  return vm;
}
