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
          radius: 750,
          weigh: 3
      }, {
          id:"SP",
          name:"Szkoła podstawowa",
          radius: 250,
          weigh: 2
      }, {
          id:"GIM",
          name:"Gimnazjum",
          radius: 250,
          weigh: 0
      }, {
          id:"LIC",
          name:"Liceum",
          radius: 250,
          weigh: 1
      }]},
       {
      _id: 1,
      name: "name2",
      preferences: [{
          id:"PRZ",
          name:"Przedszkole",
          radius: 1000,
          weigh: 2
      }, {
          id:"SP",
          name:"Szkoła podstawowa",
          radius: 1000,
          weigh: 0
      }, {
          id:"GIM",
          name:"Gimnazjum",
          radius: 1000,
          weigh: 3
      }, {
          id:"LIC",
          name:"Liceum",
          radius: 1000,
          weigh: 1
      }]}
      ]
  });
