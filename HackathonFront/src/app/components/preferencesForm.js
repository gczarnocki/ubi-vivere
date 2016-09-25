angular.module('app.components')
  .component('preferencesForm', {
    templateUrl: 'app/components/preferencesForm.html',
    controller: PreferencesFormCtrl
  })

function PreferencesFormCtrl (preferencesProvider) {
  var vm = this;
  vm.preferencesP = preferencesProvider;

  return vm;
}
