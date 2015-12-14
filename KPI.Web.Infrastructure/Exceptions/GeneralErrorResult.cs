using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace KPI.Web.Infrastructure.Exceptions
{
    public class GeneralErrorResult : IHttpActionResult
    {
        public HttpRequestMessage Request { get; set; }
        public Exception Exception { get; set; }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            HttpResponseMessage response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, Exception);
            return Task.FromResult(response);
        }
    }
}
