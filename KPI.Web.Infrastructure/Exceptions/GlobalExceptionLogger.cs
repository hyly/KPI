using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;

namespace KPI.Web.Infrastructure.Exceptions
{
    public class GlobalExceptionLogger : ExceptionLogger, IExceptionLogger
    {
        private log4net.ILog log = null;
        public override void Log(ExceptionLoggerContext context)
        {
            log = log4net.LogManager.GetLogger("myLog");
            log.Info(context.Exception.Message, context.Exception);
        }
    }
}
