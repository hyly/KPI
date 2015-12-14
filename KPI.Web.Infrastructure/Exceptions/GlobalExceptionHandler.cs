using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Results;

namespace KPI.Web.Infrastructure.Exceptions
{
    public class GlobalExceptionHandler : ExceptionHandler, IExceptionHandler
    {
        public override void Handle(ExceptionHandlerContext context)
        {
          
            var response = context.Request.CreateErrorResponse(HttpStatusCode.InternalServerError, context.Exception);
            context.Result = new GeneralErrorResult
            {
                Request = context.Request,
                Exception = context.ExceptionContext.Exception
            };
        }
    }
}
