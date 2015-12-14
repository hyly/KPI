'use strict';

describe('Directive: products', function () {

  // load the directive's module
  beforeEach(module('kpiApp'));

  var element,
    scope;

  beforeEach(inject(function ($rootScope) {
    scope = $rootScope.$new();
  }));

  it('should make hidden element visible', inject(function ($compile) {
    element = angular.element('<products></products>');
    element = $compile(element)(scope);
    expect(element.text()).toBe('this is the products directive');
  }));
});
