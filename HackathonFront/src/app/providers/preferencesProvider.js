angular.module('app.providers')
  .factory('preferencesProvider', PreferencesProviderService);

  function PreferencesProviderService() {
    return {
      preferences: [
      {
          id:"PRZ",
          name:"Przedszkole",
          radius: 0,
          weigh: 0
      }, {
          id:"SP",
          name:"Szkoła podstawowa",
          radius: 0,
          weigh: 0
      }, {
          id:"GIM",
          name:"Gimnazjum",
          radius: 0,
          weigh: 0
      }, {
          id:"LIC",
          name:"Liceum",
          radius: 0,
          weigh: 0
      }]
    }
  }
