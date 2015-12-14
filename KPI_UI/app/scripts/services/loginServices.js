'use strict';

/**
 * @ngdoc service
 * @name kpiApp.loginServices
 * @description
 * # loginServices
 * Service in the kpiApp.
 */
angular.module('kpiApp')
  .service('loginServices',['$http', function ($http) {
      return {
          doLogin: function (userName, password, onSuccess, onFailure) {
              var api = "Account/Login";
              $http.post(KPI.globalValues.servicesUrl + api, {
                  "userName": userName,
                  "password": password
              }).then(onSuccess, onFailure);
          }
      }
  }]);
