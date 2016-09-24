angular.module('app.components')
  .component('radiusInput', {
    templateUrl: 'app/components/radiusInput.html',
    controller: RadiusInputCtrl,
    bindings: {
      radius: '='
    }
  })

function RadiusInputCtrl () {
  var vm = this;
  vm.radius = 1;
  vm.inputRadius = 1;

  vm.updateRadius = function(r) {
    vm.radius = Math.max(r,0);
    vm.inputRadius = vm.radius;
   };

  return vm
}
