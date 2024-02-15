using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.ItineraryTypeDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.ItineraryTypeDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.CMS
{
    public class ItineraryTypeProfile : Profile
    {
        public ItineraryTypeProfile()
        {
            /// Start ItineraryType 
            CreateMap<CMSItineraryTypeRequestDto, ItineraryType>();
            CreateMap<ItineraryType, CMSBasicItineraryTypeResponseDto>()
                .ForMember(dest => dest.ItineraryTypeId, opt => opt.MapFrom(src => src.Id));

            CreateMap<ItineraryType, CMSItineraryTypeWithContentResponseDto>().ForMember(dest => dest.ItineraryTypeId, opt => opt.MapFrom(src => src.Id))
               .AfterMap((src, dest) =>
               {
                   if (src.ItineraryTypeContents.Count > 0)
                       MapperExtensions.MapProperties(src.ItineraryTypeContents.FirstOrDefault(), dest);
               });


            /// Start ItineraryType Content

            CreateMap<ItineraryTypeContent, CMSItineraryTypeContentResponseDto>()
                .ForMember(dest => dest.ItineraryTypeContentId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ItineraryTypeId, opt => opt.MapFrom(src => src.OriginalTableId));
            CreateMap<CMSItineraryTypeContentRequestDto, ItineraryTypeContent>();

        }
    }
}
