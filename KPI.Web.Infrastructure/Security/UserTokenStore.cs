using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPI.Web.Infrastructure.Security
{
    public static class UserTokenStore
    {
        private static readonly Hashtable UserTokens = new Hashtable();

        public static void AddToken(string username, UserToken userToken)
        {
            if (UserTokens.ContainsKey(username)) UserTokens[username] = userToken;
            else UserTokens.Add(username, userToken);
        }

        public static UserToken GetUserToken(string username)
        {
            return UserTokens.ContainsKey(username) ? (UserToken)UserTokens[username] : null;
        }

        public static void DeleteUserToken(string username)
        {
            if (UserTokens.ContainsKey(username)) UserTokens.Remove(username);
        }
    }
}
