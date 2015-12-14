using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KPI.BusinessObjects
{
    [DataContract]
    public class ProfileDto
    {
        [DataMember(Name = "profileId")]
        public int ProfileId { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "users")]
        public List<UserDto> Users { get; set; }
    }
}
