using KPI.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace KPI.Web.Api.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ProfileController : ApiController
    {
        private IProfileServices profileServices = null;
        public ProfileController(IProfileServices profileServices)
        {
            this.profileServices = profileServices;
        }

        [HttpGet]
        public List<ProfileDto> GetProfiles() {
            return this.profileServices.GetProfiles();

        }
    }
}
