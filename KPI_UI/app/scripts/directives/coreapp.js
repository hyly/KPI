'use strict';

/**
 * @ngdoc directive
 * @name kpiApp.directive:coreApp
 * @description
 * # coreApp
 */
angular.module('kpiApp').controller('coreAppController', ['$http', '$scope', 'commonServices', function ($http, $scope, commonServices) {
    $scope.selectMetro = function (metro) {
        switch (metro) {
            case "user":
                commonServices.loadContent("users", null, $scope);
                break;
            case "product":
                commonServices.loadContent("products", null, $scope);
                break;
            default:
                break;
        }
    }
}])
  .directive('coreApp', function () {
    return {
      templateUrl: '/views/coreapp.html',
      controller:'coreAppController',
      restrict: 'E',
      link: function postLink(scope, element, attrs) {
        
      }
    };
  });
