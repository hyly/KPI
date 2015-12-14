'use strict';

/**
 * @ngdoc service
 * @name kpiApp.productServices
 * @description
 * # productServices
 * Service in the kpiApp.
 */
angular.module('kpiApp')
  .factory('productServices', ['$http', function ($http) {
      return {
          getProducts: function (onSuccess, onFailure) {
              var url = "http://localhost/KPI.Web.Api/api/Product/GetAllProducts";
              $http.get(url).then(onSuccess, onFailure);
          }
      };
  }]);
