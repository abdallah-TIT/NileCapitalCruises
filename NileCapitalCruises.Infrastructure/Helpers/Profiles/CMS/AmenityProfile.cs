using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.AmenityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.AmenityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CabinAmenityDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.CMS
{
    public class AmenityProfile : Profile
    {
        public AmenityProfile()
        {
            /// Start Amenity
            CreateMap<AmenityRequestDto, Amenity>();
            CreateMap<Amenity, BasicAmenityResponseDto>();
            CreateMap<Amenity, AmenityWithContentResponseDto>().ForMember(dest => dest.AmenityId, opt => opt.MapFrom(src => src.Id))
               .AfterMap((src, dest) =>
               {
                   if (src.AmenityContents.Count > 0)
                       MapperExtensions.MapProperties(src.AmenityContents.FirstOrDefault(), dest);
               });


            /// Start Amenity Content

            CreateMap<AmenityContent, AmenityContentResponseDto>();
            CreateMap<AmenityContentRequestDto, AmenityContent>();
        }
    }
}
