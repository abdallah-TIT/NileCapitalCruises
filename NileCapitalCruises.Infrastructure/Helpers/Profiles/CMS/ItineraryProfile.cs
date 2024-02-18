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

            CreateMap<Itinerary, CMSItineraryWithContentResponseDto>().ForMember(dest => dest.ItineraryId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Days, opt => opt.MapFrom(src => src.Duration.Days))
                .ForMember(dest => dest.Nights, opt => opt.MapFrom(src => src.Duration.Nights))
                .ForMember(dest => dest.CompanyNameSys, opt => opt.MapFrom(src => src.Company.CompanyNameSys))
                .ForMember(dest => dest.CruiseNameSys, opt => opt.MapFrom(src => src.Cruise.CruiseNameSys))
                .ForMember(dest => dest.ItineraryTypeNameSys, opt => opt.MapFrom(src => src.ItineraryType.ItineraryTypeNameSys))
                .ForMember(dest => dest.WeekDayNameSys, opt => opt.MapFrom(src => src.WeekDay.WeekDayNameSys))
                .ForMember(dest => dest.CityFromNameSys, opt => opt.MapFrom(src => src.CityFrom.CityNameSys))
                .ForMember(dest => dest.CityFromName, opt => opt.MapFrom(src => src.CityFrom.CityContents.FirstOrDefault().CityName))
                .ForMember(dest => dest.CityToNameSys, opt => opt.MapFrom(src => src.CityTo.CityNameSys))
                .ForMember(dest => dest.CityToName, opt => opt.MapFrom(src => src.CityTo.CityContents.FirstOrDefault().CityName))
               .AfterMap((src, dest) =>
               {
                   if (src.ItineraryContents.Count > 0)
                       MapperExtensions.MapProperties(src.ItineraryContents.FirstOrDefault(), dest);
                   if (src.Company.CompanyContents.Count > 0)
                       MapperExtensions.MapProperties(src.Company.CompanyContents.FirstOrDefault(), dest);
                   if (src.Cruise.CruiseContents.Count > 0)
                       MapperExtensions.MapProperties(src.Cruise.CruiseContents.FirstOrDefault(), dest);
                   if (src.ItineraryType.ItineraryTypeContents.Count > 0)
                       MapperExtensions.MapProperties(src.ItineraryType.ItineraryTypeContents.FirstOrDefault(), dest);
                   if (src.WeekDay.WeekDayContents.Count > 0)
                       MapperExtensions.MapProperties(src.WeekDay.WeekDayContents.FirstOrDefault(), dest);


                  
               });

            /// Start Itinerary Content

            CreateMap<ItineraryContent, CMSItineraryContentResponseDto>()
                .ForMember(dest => dest.ItineraryContentId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ItineraryId, opt => opt.MapFrom(src => src.OriginalTableId));
            CreateMap<CMSItineraryContentRequestDto, ItineraryContent>();
        }
    }
}
