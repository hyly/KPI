using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPI.BusinessObjects
{
    public interface IUserServices
    {
        List<UserDto> GetAllUsers();
        UserDto GetUser(int userId);
        void UpdateUser(UserDto user);
        //void CreateUser(UserDto user);
        bool ValidateUser(string userName, string password);
    }
}
