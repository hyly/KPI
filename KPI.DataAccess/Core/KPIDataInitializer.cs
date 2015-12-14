using System;
using System.Collections.Generic;
using System.Data.Entity;
using KPI.DomainModel.Entities;
namespace KPI.DataAccess.Core
{
    public class KPIDataInitializer : DropCreateDatabaseIfModelChanges<KPIDataContext>
    {
        protected override void Seed(KPIDataContext context)
        {
            context.Products.Add(new Product() { 
                Active=true,Color="Yellow",Name="Test Product 1",Price=189
            });
            context.Products.Add(new Product()
            {
                Active = true,
                Color = "Yellow",
                Name = "Test Product 2",
                Price = 189,
            });
            context.Products.Add(new Product()
            {
                Active = true,
                Color = "Yellow",
                Name = "Test Product 3",
                Price = 189
            });
            context.Products.Add(new Product()
            {
                Active = true,
                Color = "Yellow",
                Name = "Test Product 4",
                Price = 189
            });
            context.Products.Add(new Product()
            {
                Active = true,
                Color = "Yellow",
                Name = "Test Product 5",
                Price = 189
            });
            context.Products.Add(new Product()
            {
                Active = true,
                Color = "Yellow",
                Name = "Test Product 6",
                Price = 189
            });
            context.Profiles.Add(new Profile()
            {
                Name = "administrator",
                IsActived = true
            });
            context.Users.Add(new User()
            {
                UserName = "admin",
                Password = "JFURQoQv9c+KB8SFXXfGqQ==#####",
                ProfileId = 1,
                IsActived = true
            });
            base.Seed(context);
        }
    }
}
