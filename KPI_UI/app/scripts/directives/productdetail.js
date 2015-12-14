'use strict';

/**
 * @ngdoc directive
 * @name kpiApp.directive:productDetail
 * @description
 * # productDetail
 */
angular.module('kpiApp')
  .directive('productDetail', function () {
    return {
      template: '<div></div>',
      restrict: 'E',
      link: function postLink(scope, element, attrs) {
        element.text('this is the productDetail directive');
      }
    };
  });
