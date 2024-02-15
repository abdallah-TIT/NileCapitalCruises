using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinAmenityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CabinAmenityDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.CMS
{
    public class CabinAmenityProfile : Profile
    {
        public CabinAmenityProfile()
        {
            /// Start CabinAmenity
            CreateMap<CabinAmenityRequestDto, CabinAmenity>();


            CreateMap<CabinAmenity, AmenityResponseDto>()
               .AfterMap((src, dest) =>
               {
                   if (src.Amenity != null)
                       MapperExtensions.MapProperties(src.Amenity, dest);
                   if (src.Amenity.AmenityContents.Count > 0)
                       MapperExtensions.MapProperties(src.Amenity.AmenityContents.FirstOrDefault(), dest);
               }).ForMember(dest => dest.AmenityId, opt => opt.MapFrom(src => src.Amenity.Id));



        }
    }
}
