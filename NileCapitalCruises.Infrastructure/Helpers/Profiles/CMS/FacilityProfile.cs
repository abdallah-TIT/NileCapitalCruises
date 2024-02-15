using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseFacilityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.FacilityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.ItineraryTypeDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.AmenityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.FacilityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.ItineraryDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.CMS
{
    public class FacilityProfile : Profile
    {
        public FacilityProfile()
        {
            /// Start Facility
            CreateMap<FacilityRequestDto, Facility>();
            CreateMap<Facility, BasicFacilityResponseDto>();
            CreateMap<Facility, FacilityWithContentResponseDto>().ForMember(dest => dest.FacilityId, opt => opt.MapFrom(src => src.Id))
               .AfterMap((src, dest) =>
               {
                   if (src.FacilityContents.Count > 0)
                       MapperExtensions.MapProperties(src.FacilityContents.FirstOrDefault(), dest);
               });


            /// Start Facility Content

            CreateMap<FacilityContent, FacilityContentResponseDto>();
            CreateMap<FacilityContentRequestDto, FacilityContent>();
        }
    }
}
