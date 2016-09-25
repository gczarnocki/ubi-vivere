angular.module('app.components')
  .component('profileType', {
    templateUrl: 'app/components/profileType.html',
    controller: ProfileTypeCtrl,
    bindings: {
      profile: '<',
      onSelect: '&'
    }
  });

function ProfileTypeCtrl() {
  var vm = this;

  return vm;
}
