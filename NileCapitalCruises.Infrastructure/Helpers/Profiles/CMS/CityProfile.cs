using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinTypeCruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.DurationDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.ItineraryDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.SeasonDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.CMS
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            /// Start City
            CreateMap<CityRequestDto, City>();
            CreateMap<City, BasicCityResponseDto>();

            CreateMap<City, CityWithContentResponseDto>().ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.Id))
               .AfterMap((src, dest) =>
               {
                   if (src.CityContents.Count > 0)
                       MapperExtensions.MapProperties(src.CityContents.FirstOrDefault(), dest);
               });
        }
    }
}
