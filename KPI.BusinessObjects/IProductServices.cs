using KPI.DataAccess.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KPI.BusinessObjects
{
    public interface IProductServices
    {
        ProductDto GetProductById(int id);
        List<ProductDto> GetAllProducts();
        PageResult<ProductDto> GetProducts(Page page);
        PageResult<ProductDto> GetProducts(Page page, Expression<Func<ProductDto, bool>> filter);
        List<ProductDto> GetProducts(Expression<Func<ProductDto, bool>> where);
        void Insert(ProductDto product);

        void Update(ProductDto product);
        void Delete(int id);
    }
}
