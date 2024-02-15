using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.CabinTypeCruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.ItineraryDtos;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.ItineraryTypeDtos;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.OperationDateDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.BookingEngine
{
    public class ItineraryProfile : Profile
    {
        public ItineraryProfile()
        {


            /// Start Itinerary 
            /// 
            CreateMap<CruisePhoto, BECruisePhotoResponseDto>();
            CreateMap<Itinerary, ItineraryWithContentResponseDto>().ForMember(dest => dest.ItineraryTypeId, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.ItineraryId, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.CruiseNameSys, opt => opt.MapFrom(src => src.Cruise.CruiseNameSys))
               .ForMember(dest => dest.CruiseMainPhoto, opt => opt.MapFrom(src => src.Cruise.CruisePhoto))
               .ForMember(dest => dest.CruiseMainPhotoHieght, opt => opt.MapFrom(src => src.Cruise.CruisePhotoHeight))
               .ForMember(dest => dest.CruiseMainPhotoWidth, opt => opt.MapFrom(src => src.Cruise.CruisePhotoWidth))
               .ForMember(dest => dest.CruisePhotos, opt => opt.MapFrom(src => src.Cruise.CruisePhotos))
                .AfterMap((src, dest) =>
                {
                    if (src.ItineraryContents.Count > 0)
                   
                        MapperExtensions.MapProperties(src.ItineraryContents.FirstOrDefault(), dest);
                    if (src.Cruise.CruiseContents.Count > 0)
                        MapperExtensions.MapProperties(src.Cruise.CruiseContents.FirstOrDefault(), dest);
                   
                });
        }
    }
}
