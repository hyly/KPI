using KPI.BusinessObjects;
using KPI.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPI.Services
{
    public class ProfileServices : IProfileServices
    {
        private IProfileRepository profileRepository = null;
        private IUnitOfWork unitOfWork = null;
        public ProfileServices(IProfileRepository profileRepository,IUnitOfWork unitOfWork)
        {
            this.profileRepository = profileRepository;
            this.unitOfWork = unitOfWork;
        }
        public List<ProfileDto> GetProfiles()
        {
            var entities=this.profileRepository.GetAll("Users").ToList();
            return entities.Select(entity => AutoMapper.Mapper.Map<ProfileDto>(entity)).ToList();
        }

        public ProfileDto GetProfileByName(string name)
        {
            var entity = this.profileRepository.Get(e => e.Name.Equals(name,StringComparison.OrdinalIgnoreCase));
            return AutoMapper.Mapper.Map<ProfileDto>(entity);
        }
    }
}
