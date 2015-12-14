using KPI.Web.Infrastructure.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace KPI.Web.Infrastructure
{
    public static class SecurityProvider
    {
        public static UserToken CreateToken(string userName, string ipAddress,int timeOut = 15)
        {
            UserToken tokenData = new UserToken(userName, ipAddress, timeOut);
            UserTokenStore.AddToken(userName, tokenData);
            return tokenData;
        }
    }
}
