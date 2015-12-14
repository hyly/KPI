using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using KPI.BusinessObjects;
using KPI.DomainModel.Entities;
using KPI.DataAccess.Core;
using KPI.DataAccess.Interfaces;
using KPI.Services.Extensions;
namespace KPI.Services
{
    public class ProductServices : IProductServices
    {
        private IUnitOfWork unitOfWork = null;
        private IProductRepository productRepository = null;
        public ProductServices(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            this.productRepository = productRepository;
            this.unitOfWork = unitOfWork;
        }

        public ProductDto GetProductById(int id)
        {
            var entity = this.productRepository.GetById(id);
            return AutoMapper.Mapper.Map<ProductDto>(entity);
        }

        public List<ProductDto> GetAllProducts()
        {
            var entities = this.productRepository.GetAll().ToList();
            var results = entities.Select(it => AutoMapper.Mapper.Map<ProductDto>(it)).ToList();
            return results;
        }

        public PageResult<ProductDto> GetProducts(Page page)
        {
            var entities = this.productRepository.GetPage<string>(page, p => 1 == 1, o => o.Name);
            var result = new PageResult<ProductDto>(entities.Data.Select(it => AutoMapper.Mapper.Map<ProductDto>(it)), page, entities.TotalCount);
            return result;
        }

        public PageResult<ProductDto> GetProducts(Page page, Expression<Func<ProductDto, bool>> filter)
        {
            var entities = this.productRepository.GetPage<string>(page, filter.RemapForType<ProductDto, Product, bool>(), o => o.Name);
            var result = new PageResult<ProductDto>(entities.Data.Select(it => AutoMapper.Mapper.Map<ProductDto>(it)), page, entities.TotalCount);
            return result;
        }

        public List<ProductDto> GetProducts(Expression<Func<ProductDto, bool>> where)
        {
            var filter = where.RemapForType<ProductDto, Product, bool>();
            var results = this.productRepository.GetMany(filter).ToList();
            return results.Select(it => AutoMapper.Mapper.Map<ProductDto>(it)).ToList();
        }

        public void Insert(ProductDto product)
        {
            this.productRepository.Add(new Product()
            {
                Active = product.Active,
                Color = product.Color,
                Description = product.Description,
                DisplayOrder = product.DisplayOrder,
                ImagePath = product.ImagePath,
                MetaDescription = product.MetaDescription,
                MetaKeywords = product.MetaKeywords,
                MetaTitle = product.MetaTitle,
                Name = product.Name,
                Price = product.Price
            });
            unitOfWork.SaveChanges();
        }


        public void Update(ProductDto product)
        {
            this.productRepository.Update(new Product()
            {
                ProductId = product.ProductId,
                Active = product.Active,
                Color = product.Color,
                Description = product.Description,
                DisplayOrder = product.DisplayOrder,
                ImagePath = product.ImagePath,
                MetaDescription = product.MetaDescription,
                MetaKeywords = product.MetaKeywords,
                MetaTitle = product.MetaTitle,
                Name = product.Name,
                Price = product.Price
            });
            this.unitOfWork.SaveChanges();
        }

        public void Delete(int id)
        {
            this.productRepository.DeleteById(id);
            this.unitOfWork.SaveChanges();
        }
    }
}
