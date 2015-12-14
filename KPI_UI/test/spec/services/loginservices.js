'use strict';

describe('Service: loginServices', function () {

  // load the service's module
  beforeEach(module('kpiApp'));

  // instantiate service
  var loginServices;
  beforeEach(inject(function (_loginServices_) {
    loginServices = _loginServices_;
  }));

  it('should do something', function () {
    expect(!!loginServices).toBe(true);
  });

});
