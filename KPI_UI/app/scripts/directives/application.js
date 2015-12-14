'use strict';

/**
 * @ngdoc directive
 * @name kpiApp.directive:login
 * @description
 * # login
 */
angular.module('kpiApp').controller('applicationController', ['$http', '$scope', 'loginServices', 'globalServices', function ($http, $scope, loginServices, globalServices) {
    $scope.appData = {};
    $scope.doLogin = function () {
        loginServices.doLogin($scope.userName, $scope.password,
            function (response) {
                globalServices.setTokenData(response.data.Token);
                $http.defaults.headers.common.Authorization = "Basic " + globalServices.getTokenData();
                $scope.appData.token = globalServices.getTokenData();
            },
            function (error) {
                $scope.appData.loginError = error.data.ExceptionMessage;
            });
    }
}])
  .directive('application', function () {
      return {
          templateUrl: '/views/application.html',
          restrict: 'E',
          controller: 'applicationController',
          link: function (scope, element, attrs) {
          }
      };
  });
