
using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.AmenityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.DiningDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CabinDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CabinTypeCruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.DiningDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.CMS
{
    public class CabinProfile : Profile
    {
        public CabinProfile()
        {
            /// Start Cabin
            CreateMap<CabinRequestDto, Cabin>();
            CreateMap<Cabin, BasicCabinResponseDto>();
            CreateMap<Cabin, CabinWithContentResponseDto>().ForMember(dest => dest.CabinId, opt => opt.MapFrom(src => src.Id))
               .AfterMap((src, dest) =>
               {
                   if (src.CabinContents.Count > 0)
                       MapperExtensions.MapProperties(src.CabinContents.FirstOrDefault(), dest);
               });


            /// Start Cabin Content

            CreateMap<CabinContent, CabinContentResponseDto>();
            CreateMap<CabinContentRequestDto, CabinContent>();


            // For Photos

            CreateMap<CabinPhotoRequestDto, CabinPhoto>();
            CreateMap<CabinPhoto, CabinPhotoResponseDto>();

        }
    }
}
