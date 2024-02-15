using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinTypeDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CabinTypeDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CityDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.CMS
{
    public class CabinTypeProfile : Profile
    {
        public CabinTypeProfile()
        {
            CreateMap<CabinTypeRequestDto, CabinType>();
            CreateMap<CabinType, BasicCabinTypeResponseDto>();
            CreateMap<CabinType, CabinTypeWithContentResponseDto>()
               .AfterMap((src, dest) =>
               {
                   if (src.CabinTypeContents.Count > 0)
                       MapperExtensions.MapProperties(src.CabinTypeContents.FirstOrDefault(), dest);
               });

            ///
            /// Start CabinType Content

            CreateMap<CabinTypeContent, CabinTypeContentResponseDto>();
            CreateMap<CabinTypeContentRequestDto, CabinTypeContent>();
        }
    }
}
