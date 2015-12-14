using KPI.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Filters;
using System.Web.Http.Results;

namespace KPI.Web.Infrastructure.Security
{
    public class HostAuthenticationFilter : Attribute, IAuthenticationFilter
    {
        public Task AuthenticateAsync(HttpAuthenticationContext context, System.Threading.CancellationToken cancellationToken)
        {
           // !context.ActionContext.ActionDescriptor.ActionName.Equals("Login") 
            var req = context.Request;
            // Get credential from the Authorization header 
            //(if present) and authenticate
            if (context.ActionContext.ActionDescriptor.ActionName.Equals("Login"))
            {
                return Task.FromResult(0);
            }
            else if (req.Headers.Authorization != null
                && "Basic".Equals(req.Headers.Authorization.Scheme, StringComparison.OrdinalIgnoreCase))
            {
                var creds = req.Headers.Authorization.Parameter;
                var userName = Encryptor.Decrypt(creds).Split(':')[0] ?? string.Empty;
                var userToken = UserTokenStore.GetUserToken(userName);
                if (userToken != null && creds == userToken.Token) // Replace with a real check
                {
                    var claims = new List<Claim>()
                  {
                    new Claim(ClaimTypes.Name, userName),
                    new Claim(ClaimTypes.Role, "admin")
                  };
                    var id = new ClaimsIdentity(claims, "Token");
                    var principal = new ClaimsPrincipal(id);
                    // The request message contains valid credential
                    context.Principal = principal;
                }
                else
                {
                    // The request message contains invalid credential
                    context.ErrorResult = new UnauthorizedResult(
                      new AuthenticationHeaderValue[0], context.Request);
                }
            }
            else
            {
                context.ErrorResult = new UnauthorizedResult(
                     new AuthenticationHeaderValue[0], context.Request);
            }
            return Task.FromResult(0);
        }

        public Task ChallengeAsync(HttpAuthenticationChallengeContext context, System.Threading.CancellationToken cancellationToken)
        {
            return Task.FromResult(0);
        }

        public bool AllowMultiple
        {
            get { throw new NotImplementedException(); }
        }
    }
}
