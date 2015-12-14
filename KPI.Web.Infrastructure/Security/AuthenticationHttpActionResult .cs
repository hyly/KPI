using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace KPI.Web.Infrastructure.Security
{
    public class AuthenticationHttpActionResult:IHttpActionResult
    {
        public Task<System.Net.Http.HttpResponseMessage> ExecuteAsync(System.Threading.CancellationToken cancellationToken)
        {
            return Task.FromResult(Execute());
        }
        private HttpResponseMessage Execute()
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
            //response.RequestMessage = Request;
            //response.ReasonPhrase = ReasonPhrase;
            return response;
        }
    }
}
