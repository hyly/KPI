using KPI.BusinessObjects;
using KPI.Services;
using KPI.Web.Api.Models;
using KPI.Web.Infrastructure;
using KPI.Web.Infrastructure.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace KPI.Web.Api.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AccessController : ApiController
    {
        private IUserServices userServices = null;
        private IProfileServices profileServices = null;
        public AccessController(IUserServices userServices,IProfileServices profileServices)
        {
            this.userServices = userServices;
            this.profileServices = profileServices;
        }
        [HttpGet]
        public List<UserDto> GetAllUser() {
            return userServices.GetAllUsers();
        }

        [HttpGet]
        public UserViewModel GetUser(int userId) {
            var user = this.userServices.GetUser(userId);
            var profiles = this.profileServices.GetProfiles();

            return new UserViewModel(user, profiles);
        }

        [HttpPost]
        public void UpdateUser(UserDto user) {
            this.userServices.UpdateUser(user);
        }

        [HttpPost]
        public bool ValidateUser(LoginRequestData request) { 
            return userServices.ValidateUser(request.UserName,Encryptor.Encrypt(request.Password));
        }

        [HttpGet]
        public string EncryptText(string text) {
            return Encryptor.Encrypt(text);
        }
	}
}