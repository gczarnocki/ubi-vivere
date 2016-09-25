angular.module('app.components')
  .component('preferencesForm', {
    templateUrl: 'app/components/preferencesForm.html',
    controller: PreferencesFormCtrl,
    bindings: {
      value: '<',
      preferences: '='
    }
  })

function PreferencesFormCtrl () {
  var vm = this;

  return vm;
}
