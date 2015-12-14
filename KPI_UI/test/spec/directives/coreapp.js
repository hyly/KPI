'use strict';

describe('Directive: coreApp', function () {

  // load the directive's module
  beforeEach(module('kpiApp'));

  var element,
    scope;

  beforeEach(inject(function ($rootScope) {
    scope = $rootScope.$new();
  }));

  it('should make hidden element visible', inject(function ($compile) {
    element = angular.element('<core-app></core-app>');
    element = $compile(element)(scope);
    expect(element.text()).toBe('this is the coreApp directive');
  }));
});
