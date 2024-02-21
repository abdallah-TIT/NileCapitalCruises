using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.PeriodDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.PeriodDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.CMS
{
    public class PeriodProfile : Profile
    {
        public PeriodProfile()
        {
            /// Start Period
            CreateMap<CMSPeriodRequestDto, Period>();
                
            CreateMap<Period, CMSBasicPeriodResponseDto>()
                .ForMember(dest => dest.PeriodId, opt => opt.MapFrom(src => src.Id));

            CreateMap<City, CityWithContentResponseDto>().ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.Id))
               .AfterMap((src, dest) =>
               {
                   if (src.CityContents.Count > 0)
                       MapperExtensions.MapProperties(src.CityContents.FirstOrDefault(), dest);
               });
        }
    }
}
