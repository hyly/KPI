using KPI.BusinessObjects;
using KPI.Services;
using KPI.Web.Api.Models;
using KPI.Web.Infrastructure;
using KPI.Web.Infrastructure.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace KPI.Web.Api.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AccountController : ApiController
    {
        private IUserServices userServices = null;
        public AccountController(IUserServices userServices)
        {
            this.userServices = userServices;
        }
        [HttpPost]
        public UserToken Login(LoginRequestData requestData)
        {
            var isValid = userServices.ValidateUser(requestData.UserName, Encryptor.Encrypt(requestData.Password));
            if (isValid)
            {
                var token = SecurityProvider.CreateToken(requestData.UserName, HttpContext.Current.Request.UserHostAddress);
                return token;
            }
            throw new Exception(Request.Headers.Authorization.Parameter);
        }
    }
}
