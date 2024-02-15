using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.ItineraryTypeDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.DiningDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.DiningDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.DurationDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.CMS
{
    public class DiningProfile : Profile
    {
        public DiningProfile()
        {
            /// Start Dining 
            CreateMap<CreateDiningRequestDto, Dining>();
            CreateMap<UpdateDiningRequestDto, Dining>();
            CreateMap<Dining, BasicDiningResponseDto>();

            CreateMap<Dining, DiningWithContentResponseDto>().ForMember(dest => dest.DiningId, opt => opt.MapFrom(src => src.Id))
              .AfterMap((src, dest) =>
              {
                  if (src.DiningContents.Count > 0)
                      MapperExtensions.MapProperties(src.DiningContents.FirstOrDefault(), dest);
              });


            /// Start Dining Content

            CreateMap<DiningContent, DiningContentResponseDto>();
            CreateMap<DiningContentRequestDto, DiningContent>();


            // For Photos

            CreateMap<DiningPhotoRequestDto, DiningPhoto>();
            CreateMap<DiningPhoto, DiningPhotoResponseDto>();
        }
    }
}
