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
          genitiv:"przedszkola",
          isSwitchOn:false,
          radius: 250,
          weigh: 1
      }, {
          id:"SP",
          name:"Szkoła podstawowa",
          genitiv:"szkoły podstawowej",
          isSwitchOn:false,
          radius: 250,
          weigh: 1
      }, {
          id:"GIM",
          name:"Gimnazjum",
          genitiv:"gimnazjum",
          isSwitchOn:false,
          radius: 250,
          weigh: 1
      }, {
          id:"LIC",
          name:"Liceum",
          genitiv:"liceum",
          isSwitchOn:false,
          radius: 250,
          weigh: 1
      }
  ];

  return vm;
}
