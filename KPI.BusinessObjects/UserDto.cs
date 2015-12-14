using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KPI.BusinessObjects
{
    [DataContract]
    public class UserDto
    {
        [DataMember(Name = "userId")]
        public int UserId { get; set; }
        [DataMember(Name = "userName")]
        public string UserName { get; set; }
        public string Password { get; set; }
        [DataMember(Name = "isActive")]
        public bool IsActived { get; set; }
        [DataMember(Name = "profileId")]
        public int ProfileId { get; set; }
        [DataMember(Name = "profile")]
        public ProfileDto Profile { get; set; }
    }
}
