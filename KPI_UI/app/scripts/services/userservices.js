'use strict';

/**
 * @ngdoc service
 * @name kpiApp.userServices
 * @description
 * # userServices
 * Service in the kpiApp.
 */
angular.module('kpiApp')
  .factory('userServices', ['$http', function ($http) {
      var baseUrl = KPI.globalValues.servicesUrl + "Access/";
      return {
          getUsers: function (onSuccess, onFailure) {
              var url = baseUrl + "GetAllUser";
              $http.get(url).then(onSuccess, onFailure);
          },
          getUser: function (userId, onSuccess, onFailure)
          {
              var url = baseUrl + "GetUser?userId=" + userId;
              $http.get(url).then(onSuccess, onFailure);
          },
          updateUser: function (user, onSuccess, onFailure) {
              var url = baseUrl + "UpdateUser";
              $http.post(url, user).then(onSuccess, onFailure);
          }
      };
  }]);
