using KPI.DataAccess.Core;
using KPI.DataAccess.Interfaces;
using KPI.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPI.DataAccess.Repositories
{
    public class UserRepository : EFGenericRepository<User>, IUserRepository
    {
        public UserRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }
}
