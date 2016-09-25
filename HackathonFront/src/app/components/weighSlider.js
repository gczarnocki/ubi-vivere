angular.module('app.components')
  .component('weighSlider', {
    templateUrl: 'app/components/weighSlider.html',
    controller: WeighSliderCtrl,
    bindings: {
      weigh: '='
    }
  })

function WeighSliderCtrl () {
  var vm = this;
  vm.weigh = 1;

  vm.options = {
    showTicksValues: true,
    hideLimitLabels: true,
    stepsArray: [
      {value: 1, legend: 'Niski'},
      {value: 2, legend: 'Średni'},
      {value: 3, legend: 'Wysoki'}
    ],
    translate: function(value) {
      return '';
    }
  };

  return vm;
}
