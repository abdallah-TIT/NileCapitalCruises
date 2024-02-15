using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.BrandDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.DiningTypeDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.BrandDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.DiningTypeDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.CMS
{
    public class DiningTypeProfile : Profile
    {
        public DiningTypeProfile()
        {
            /// Start DiningType
            CreateMap<DiningTypeRequestDto, DiningType>();
            CreateMap<DiningType, BasicDiningTypeResponseDto>();

            CreateMap<DiningType, DiningTypeWithContentResponseDto>().ForMember(dest => dest.DiningTypeId, opt => opt.MapFrom(src => src.Id))
              .AfterMap((src, dest) =>
              {
                  if (src.DiningTypeContents.Count > 0)
                      MapperExtensions.MapProperties(src.DiningTypeContents.FirstOrDefault(), dest);
              });


            /// Start DiningType Content

            CreateMap<DiningTypeContent, DiningTypeContentResponseDto>();
            CreateMap<DiningTypeContentRequestDto, DiningTypeContent>();
        }
    }
}
