using AutoMapper;
using KPI.BusinessObjects;
using KPI.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPI.Services
{
    public class KPIMapper
    {
        public static void CreateObjectServicesMap()
        {
            Mapper.CreateMap<Product, ProductDto>();
            Mapper.CreateMap<User, UserDto>()
                .ForMember(dest => dest.Profile, opt => opt.MapFrom(src => src.Profile));
            Mapper.CreateMap<KPI.DomainModel.Entities.Profile, ProfileDto>()
                .ForMember(dest => dest.Users, opt => opt.MapFrom(src => src.Users));
        }
    }
}
