angular.module('app.components')
  .component('radiusInput', {
    templateUrl: 'app/components/radiusInput.html',
    controller: RadiusInputCtrl,
    bindings: {
      radius: '=',
      weigh: '='
    }
  })

function RadiusInputCtrl () {
  var vm = this;
  vm.radius = 250;
  
  vm.options = {
    hideLimitLabels: true,
    showTicks: true,
    stepsArray: [
      {value: 250, legend: ''},
      {value: 500, legend: ''},
      {value: 750, legend: ''},
      {value: 1000, legend: '1000m'},
      {value: 1250, legend: ''},
      {value: 1500, legend: ''},
      {value: 1750, legend: ''},
      {value: 2000, legend: '2000m'}
    ],
    translate: function(value) {
      return value + 'm';
      }
    };

  return vm;
}


