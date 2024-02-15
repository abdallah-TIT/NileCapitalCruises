using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.ItineraryDtos;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.ItineraryTypeDtos;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.OperationDateDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.BookingEngine
{
    public class ItineraryTypeProfile : Profile
    {
        public ItineraryTypeProfile()
        {
          

            /// Start ItineraryType 
            /// 

            CreateMap<ItineraryType, ItineraryTypeWithContentResponseDto>().ForMember(dest => dest.ItineraryTypeId, opt => opt.MapFrom(src => src.Id))
               .AfterMap((src, dest) =>
               {
                   if (src.ItineraryTypeContents.Count > 0)
                       MapperExtensions.MapProperties(src.ItineraryTypeContents.FirstOrDefault(), dest);
               });
        }
    }
}
