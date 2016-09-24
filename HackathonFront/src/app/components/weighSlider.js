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
  vm.weigh = 0;
  vm.minWeigh = 0;
  vm.maxWeigh = 10;

  return vm
}
