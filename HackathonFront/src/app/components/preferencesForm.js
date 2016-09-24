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
  ]

  return vm
}
