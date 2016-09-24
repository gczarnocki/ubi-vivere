angular.module('app.components')
  .component('mapDisplay', {
    templateUrl: 'app/components/mapDisplay.html',
    controller: MapDisplayController,
    controllerAs: 'mapDisplay'
  })

function MapDisplayController(NgMap, constants) {
  var vm = this;

  vm.googleMapsUrl="https://maps.googleapis.com/maps/api/js?key=" + constants.GOOGLE_API_KEY;

  NgMap.getMap();

}
