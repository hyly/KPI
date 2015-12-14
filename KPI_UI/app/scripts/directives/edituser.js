'use strict';

/**
 * @ngdoc directive
 * @name kpiApp.directive:editUser
 * @description
 * # editUser
 */
angular.module('kpiApp').controller('editUserController', ['$http', '$scope', 'userServices', 'commonServices', function ($http, $scope, userServices, commonServices) {
    $scope.profiles = [];
    $scope.user = null;
    $scope.init = function () {
        userServices.getUser($scope.userId,
            function (response) {
                $scope.profiles = response.data.profile;
                $scope.user = response.data.user;
            },
            function (error) {
                $scope.exception.message = error.data.ExceptionMessage;
            });
    };
    $scope.save = function () {
        userServices.updateUser($scope.user,
            function (response) {
                commonServices.loadContent("users", null, $scope.$parent);
            },
            function (error) {
                $scope.exception.message = error.date.ExceptionMessage;
            });
    };
}])
  .directive('editUser', function () {
    return {
      templateUrl: '/views/edituser.html',
      restrict: 'E',
      controller:'editUserController',
      link: function postLink(scope, element, attrs) {
          scope.init();
      }
    };
  });
