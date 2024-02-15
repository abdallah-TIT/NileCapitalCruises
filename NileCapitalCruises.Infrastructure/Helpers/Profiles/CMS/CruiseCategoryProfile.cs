using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseCategoryDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruisCategoryDtos;


namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.CMS
{
    public class CruiseCategoryProfile : Profile
    {
        public CruiseCategoryProfile()
        {

            CreateMap<CMSCruiseCategoryRequestDto, CruiseCategory>();

            CreateMap<CruiseCategory, CMSBasicCruiseCategoryResponseDto>()
                .ForMember(dest => dest.CruiseCategoryId, opt => opt.MapFrom(src => src.Id));


            CreateMap<CruiseCategory, CMSCruiseCategoryWithContentResponseDto>().ForMember(dest => dest.CruiseCategoryId, opt => opt.MapFrom(src => src.Id))
             .AfterMap((src, dest) =>
             {
                 if (src.CruiseCategoryContents.Count > 0)
                     MapperExtensions.MapProperties(src.CruiseCategoryContents.FirstOrDefault(), dest);
             });


            /// Start CruiseCategory Content

            CreateMap<CruiseCategoryContent, CMSCruiseCategoryContentResponseDto>()
                .ForMember(dest => dest.CruiseCategoryContentId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CruiseCategoryId, opt => opt.MapFrom(src => src.OriginalTableId));

            CreateMap<CMSCruiseCategoryContentRequestDto, CruiseCategoryContent>();
        }
    }
}
