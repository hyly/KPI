'use strict';

describe('Service: userServices', function () {

  // load the service's module
  beforeEach(module('kpiApp'));

  // instantiate service
  var userServices;
  beforeEach(inject(function (_userServices_) {
    userServices = _userServices_;
  }));

  it('should do something', function () {
    expect(!!userServices).toBe(true);
  });

});
