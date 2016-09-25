angular.module('app.components')
  .component('mapDisplay', {
    templateUrl: 'app/components/mapDisplay.html',
    controller: MapDisplayController,
    controllerAs: 'mapDisplay'
  })

function MapDisplayController(NgMap, constants) {
  var heatmap, vm = this;

  vm.googleMapsUrl="https://maps.googleapis.com/maps/api/js?key=" + constants.GOOGLE_API_KEY;
  vm.showHeatmap = showHeatmap;
  vm.data = [new google.maps.LatLng(37.774546, -122.433523)];

  function showHeatmap(map, data) {
    heatmap = new google.maps.visualization.HeatmapLayer();
    heatmap.setData(data);
    heatmap.setMap(map);
  }

  NgMap.getMap().then(function(map) {
      vm.map = map;
    });

  return vm;
}
