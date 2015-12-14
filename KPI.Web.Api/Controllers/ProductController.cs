using KPI.BusinessObjects;
using KPI.DataAccess.Core;
using KPI.Web.Infrastructure.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
namespace KPI.Web.Api.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ProductController : ApiController
    {
        private IProductServices productServices = null;
        public ProductController(IProductServices productServices)
        {
            this.productServices = productServices;
        }
        [HttpGet]
        public ProductDto GetProductById(int id)
        {
            return this.productServices.GetProductById(id);
        }

        [HttpGet]
        public List<ProductDto> GetAllProducts()
        {
            return this.productServices.GetAllProducts();
        }

        [HttpPost]
        public PageResult<ProductDto> GetProducts(Page page)
        {
            return this.productServices.GetProducts(page);
        }

        [HttpPost]
        public IHttpActionResult Insert(ProductDto product)
        {
            if (ModelState.IsValid)
            {
                this.productServices.Insert(product);
                return Ok();
            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        public IHttpActionResult Update(ProductDto product)
        {
            if (ModelState.IsValid)
            {
                this.productServices.Update(product);
                return Ok();
            }
            return BadRequest(ModelState);
        }
        [HttpPost]
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("id", "Product Id can not less than or equals 0.");
            }
            this.productServices.Delete(id);
            return Ok();
        }
    }
}
