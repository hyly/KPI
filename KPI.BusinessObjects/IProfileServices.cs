using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPI.BusinessObjects
{
    public interface IProfileServices
    {
        List<ProfileDto> GetProfiles();
        ProfileDto GetProfileByName(string name);
    }
}
