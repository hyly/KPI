'use strict';

describe('Directive: editUser', function () {

  // load the directive's module
  beforeEach(module('kpiApp'));

  var element,
    scope;

  beforeEach(inject(function ($rootScope) {
    scope = $rootScope.$new();
  }));

  it('should make hidden element visible', inject(function ($compile) {
    element = angular.element('<edit-user></edit-user>');
    element = $compile(element)(scope);
    expect(element.text()).toBe('this is the editUser directive');
  }));
});
