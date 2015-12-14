'use strict';

/**
 * @ngdoc service
 * @name kpiApp.productServices
 * @description
 * # productServices
 * Service in the kpiApp.
 */
angular.module('kpiApp')
  .factory('commonServices', ['$http', '$compile', '$timeout', function ($http, $compile, $timeout) {
      return {
          loadContent: function (directive, placeHolder, scope) {
              placeHolder = !placeHolder ? "#content-detail" : "#" + placeHolder;
              $(document).find(placeHolder).empty();
              $timeout(function () {
                  if (angular.isString(directive)) {
                      var html = "<" + directive + "/>";
                      ($compile(html)(scope)).appendTo($(document).find(placeHolder).empty());
                  }
              }, 100);
          }
      };
  }]);
