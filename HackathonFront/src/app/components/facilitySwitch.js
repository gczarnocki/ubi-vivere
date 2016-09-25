angular.module('app.components')
  .component('facilitySwitch', {
    templateUrl: 'app/components/facilitySwitch.html',
    controller: FacilitySwitchCtrl,
    bindings: {
      isSwitchOn: '='
    }
  })

function FacilitySwitchCtrl () {
  var vm = this;
  vm.isSwitchOn = false;

  vm.options = {
    showTicksValues: true,
    hidePointerLabels: true,
    stepsArray: [
      {isSwitchOn: false, legend: 'Wyłącz'},
      {isSwitchOn: true, legend: 'Włącz'}
    ],
    translate: function(value) {
      return '';
    }
  };

  return vm;
}
