angular.module('app.components')
  .component('radiusInput', {
    templateUrl: 'app/components/radiusInput.html',
    controller: RadiusInputCtrl,
    bindings: {
      value: '<'
    }
  })

function RadiusInputCtrl () {
  var vm = this;
  vm.value = 1;

  return vm
}
