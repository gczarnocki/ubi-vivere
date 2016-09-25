angular.module('app.components')
  .constant('constants', {
    GOOGLE_API_KEY: 'google_api_key',
    profiles: [{
      _id: 0,
      name: "name1",
      preferences: [
      {
          id:"PRZ",
          name:"Przedszkole",
          radius: 0,
          weigh: 1
      }, {
          id:"SP",
          name:"Szkoła podstawowa",
          radius: 0,
          weigh: 2
      }, {
          id:"GIM",
          name:"Gimnazjum",
          radius: 0,
          weigh: 0
      }, {
          id:"LIC",
          name:"Liceum",
          radius: 0,
          weigh: 1
      }]}, {
      _id: 1,
      name: "name2",
      preferences: [{
          id:"PRZ",
          name:"Przedszkole",
          radius: 0,
          weigh: 2
      }, {
          id:"SP",
          name:"Szkoła podstawowa",
          radius: 0,
          weigh: 0
      }, {
          id:"GIM",
          name:"Gimnazjum",
          radius: 0,
          weigh: 5
      }, {
          id:"LIC",
          name:"Liceum",
          radius: 0,
          weigh: 1
      }]}
      ]
  });
