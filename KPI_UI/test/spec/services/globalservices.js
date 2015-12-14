'use strict';

describe('Service: globalServices', function () {

  // load the service's module
  beforeEach(module('kpiApp'));

  // instantiate service
  var globalServices;
  beforeEach(inject(function (_globalServices_) {
    globalServices = _globalServices_;
  }));

  it('should do something', function () {
    expect(!!globalServices).toBe(true);
  });

});
