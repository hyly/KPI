using System;
using System.Collections.Generic;
using System.Linq;
using KPI.DataAccess.Interfaces;
using KPI.DataAccess.Core;
using KPI.DomainModel.Entities;
namespace KPI.DataAccess.Repositories
{
    public class ProductRepository:EFGenericRepository<Product>, IProductRepository
    {
        public ProductRepository(IUnitOfWork unitOfWork)
            :base(unitOfWork)
        {

        }
    }
}
