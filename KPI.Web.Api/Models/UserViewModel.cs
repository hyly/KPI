using KPI.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace KPI.Web.Api.Models
{
    [DataContract]
    public class UserViewModel
    {
        public UserViewModel(UserDto user, List<ProfileDto> profiles)
        {
            this.User = user;
            this.Profiles = profiles;
        }
        [DataMember(Name = "user")]
        public UserDto User { get; set; }
        [DataMember(Name = "profile")]
        public List<ProfileDto> Profiles { get; set; }
    }
}