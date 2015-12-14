using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KPI.Services.Cache;
using KPI.BusinessObjects;
namespace KPI.Services
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<BuiltInCache>().As<ICacheServices>().InstancePerRequest();
            builder.RegisterType<ProductServices>().As<IProductServices>().InstancePerRequest();
            builder.RegisterType<UserServices>().As<IUserServices>().InstancePerRequest();
            builder.RegisterType<ProfileServices>().As<IProfileServices>().InstancePerRequest();
        }
    }
}
