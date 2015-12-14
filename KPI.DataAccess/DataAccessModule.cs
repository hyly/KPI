using Autofac;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using KPI.DataAccess.Core;
using KPI.DataAccess.Interfaces;
using KPI.DataAccess.Repositories;

namespace KPI.DataAccess
{
    public class DataAccessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<KPIDataContext>().As<DbContext>()
                .WithParameter(new NamedParameter("nameConnectionString", "KPIDbConnection"))
                .InstancePerRequest();
            builder.RegisterType<KPIUnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<ProductRepository>().As<IProductRepository>().InstancePerRequest();
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerRequest();
            builder.RegisterType<ProfileRepository>().As<IProfileRepository>().InstancePerRequest();
        }
    }
}
