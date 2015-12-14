'use strict';

/**
 * @ngdoc service
 * @name kpiApp.globalServices
 * @description
 * # globalServices
 * Service in the kpiApp.
 */
angular.module('kpiApp')
  .service('globalServices', ['$http', function ($http) {
      // AngularJS will instantiate a singleton by calling "new" on this function
      return {
          setTokenData: function (token) {
              localStorage.setItem("token", token);
          },
          getTokenData: function () {
              return localStorage.getItem("token") || "";
          }
      }
  }]);
