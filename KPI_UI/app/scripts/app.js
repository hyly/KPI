'use strict';

/**
 * @ngdoc overview
 * @name kpiApp
 * @description
 * # kpiApp
 *
 * Main module of the application.
 */
angular
  .module('kpiApp', [
    'ngAnimate',
    'ngCookies',
    'ngResource',
    'ngRoute',
    'ngSanitize',
    'ngTouch'
  ])
  .config(function ($routeProvider) {
    $routeProvider
      .when('/', {
        templateUrl: 'views/main.html',
        controller: 'MainCtrl',
        controllerAs: 'main'
      })
      .when('/about', {
        templateUrl: 'views/about.html',
        controller: 'AboutCtrl',
        controllerAs: 'about'
      })
      .otherwise({
        redirectTo: '/'
      });
  }).config(function ($httpProvider) {
      //$httpProvider.defaults.useXDomain = true;
      //delete $httpProvider.defaults.headers.common['X-Requested-With'];
  });;
