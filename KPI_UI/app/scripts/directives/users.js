'use strict';

/**
 * @ngdoc directive
 * @name kpiApp.directive:users
 * @description
 * # users
 */
angular.module('kpiApp').controller('userController', ['$http', '$scope', 'userServices', 'commonServices', function ($http, $scope, userServices, commonServices) {
    $scope.users = null;
    $scope.init = function () {
        userServices.getUsers(
            function (response) {
                $scope.users = response.data;
            },
            function (error) {
                $scope.exception.message = error.data.ExceptionMessage;
            });
    }
    $scope.edit = function (user) {
        var newScope = $scope.$new(false);
        newScope.userId = user.userId;
        commonServices.loadContent("edit-user", null, newScope);
    }
}])
  .directive('users', function () {
    return {
      templateUrl: '/views/users.html',
      restrict: 'E',
      controller:'userController',
      link: function postLink(scope, element, attrs) {
          scope.init();
      }
    };
  });
