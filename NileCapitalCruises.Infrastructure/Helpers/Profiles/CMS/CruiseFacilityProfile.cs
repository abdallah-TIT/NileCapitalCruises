using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinAmenityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseFacilityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.FacilityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.AmenityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseFacilityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.FacilityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.ItineraryTypeDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.CMS
{
    public class CruiseFacilityProfile : Profile
    {
        public CruiseFacilityProfile()
        {
            /// Start CruiseFacility
            CreateMap<CruiseFacilityRequestDto, CruiseFacility>();


            CreateMap<CruiseFacility, FacilityResponseDto>()
               .AfterMap((src, dest) =>
               {
                   if (src.Facility != null)
                       MapperExtensions.MapProperties(src.Facility, dest);
                   if (src.Facility.FacilityContents.Count > 0)
                       MapperExtensions.MapProperties(src.Facility.FacilityContents.FirstOrDefault(), dest);
               }).ForMember(dest => dest.FacilityId, opt => opt.MapFrom(src => src.Facility.Id));



        }
    }
}
