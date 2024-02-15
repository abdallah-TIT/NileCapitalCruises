using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.ItineraryDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.ItineraryDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.CMS
{
    public class ItineraryProfile : Profile
    {
        public ItineraryProfile()
        {
            /// Start Itinerary
            CreateMap<CMSItineraryRequestDto, Itinerary>();
            CreateMap<Itinerary, CMSBasicItineraryResponseDto>()
                .ForMember(dest => dest.ItineraryId, opt => opt.MapFrom(src => src.Id));

            CreateMap<Itinerary, CMSItineraryWithContentResponseDto>().ForMember(dest => dest.CompanyId, opt => opt.MapFrom(src => src.Id))
               .AfterMap((src, dest) =>
               {
                   if (src.ItineraryContents.Count > 0)
                       MapperExtensions.MapProperties(src.ItineraryContents.FirstOrDefault(), dest);
               });

            /// Start Itinerary Content

            CreateMap<ItineraryContent, CMSItineraryContentResponseDto>()
                .ForMember(dest => dest.ItineraryContentId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ItineraryId, opt => opt.MapFrom(src => src.OriginalTableId));
            CreateMap<CMSItineraryContentRequestDto, ItineraryContent>();
        }
    }
}
