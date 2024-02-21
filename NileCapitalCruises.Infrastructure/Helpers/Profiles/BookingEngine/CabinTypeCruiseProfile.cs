using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.CabinTypeCruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.ItineraryDtos;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.ItineraryTypeDtos;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.OperationDateDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.BookingEngine
{
    public class CabinTypeCruiseProfile : Profile
    {
        public CabinTypeCruiseProfile()
        {


            /// Start Itinerary 
            /// 
            CreateMap<CabinTypeCruisePhoto, BECabinTypeCruisePhotoResponseDto>();
            CreateMap<CabinTypeCruise, CabinTypeCruiseWithContentResponseDto>().ForMember(dest => dest.CabinTypeCruiseId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Allotment, opt => opt.MapFrom(src => src.CabinTypeCruiseOperationDates./*Where(cbco => cbco.CabinTypeCruiseId == src.Id).*/FirstOrDefault().Allotment))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.CabinTypeCruiseItineraryTypePeriodRates.FirstOrDefault().Price))

                .AfterMap((src, dest) =>
                {
                    if (src.CabinType.CabinTypeContents.Count > 0)
                   
                        MapperExtensions.MapProperties(src.CabinType.CabinTypeContents.FirstOrDefault(), dest);
                    
                   
                });

            
        }
    }
}
