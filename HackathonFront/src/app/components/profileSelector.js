angular.module('app.components')
  .component('profileSelector', {
    templateUrl: 'app/components/profileSelector.hmtl',
    controller: ProfileSelectorCtrl,
    bindings: {
      profile: '<'
    }
  });

function ProfileSelectorCtrl() {
  var vm = this;

  return vm;
}
