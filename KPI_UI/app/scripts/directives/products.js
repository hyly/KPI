'use strict';

/**
 * @ngdoc directive
 * @name kpiApp.directive:products
 * @description
 * # products
 */
angular.module('kpiApp').controller('productsController', ['$http', '$scope', '$q', '$element', 'productServices',
    function ($http, $scope, $q, $element, productServices) {
        $scope.products = [];
        $scope.init = function () {
            productServices.getProducts(
                function (response) {
                    $scope.products = response.data;
                },
                function (error) {
                    console.log(error);
                });
        };
    }])
  .directive('products', function () {
      return {
          templateUrl: '/views/Products.html',
          restrict: 'E',
          controller: 'productsController',
          link: function (scope, element, attrs) {
              scope.init();
          }
      };
  });
