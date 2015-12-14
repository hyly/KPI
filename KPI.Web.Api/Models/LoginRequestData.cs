using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace KPI.Web.Api.Models
{
    [DataContract]
    public class LoginRequestData
    {
        [DataMember(Name = "userName")]
        public string UserName { get; set; }
        [DataMember(Name = "password")]
        public string Password { get; set; }
    }
}