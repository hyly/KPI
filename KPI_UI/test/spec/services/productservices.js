'use strict';

describe('Service: productServices', function () {

  // load the service's module
  beforeEach(module('kpiApp'));

  // instantiate service
  var productServices;
  beforeEach(inject(function (_productServices_) {
    productServices = _productServices_;
  }));

  it('should do something', function () {
    expect(!!productServices).toBe(true);
  });

});
