using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KPI.DomainModel.Entities;
namespace KPI.DataAccess.Core
{
    public class KPIDataContext : DbContext
    {
        public KPIDataContext(string nameConnectionString)
            : base(nameConnectionString)
        {
            Database.SetInitializer<KPIDataContext>(new KPIDataInitializer());
            this.Configuration.LazyLoadingEnabled = false;
        }
        public virtual IDbSet<Product> Products { get; set; }
        public virtual IDbSet<User> Users { get; set; }
        public virtual IDbSet<Profile> Profiles { get; set; }
    }
}
