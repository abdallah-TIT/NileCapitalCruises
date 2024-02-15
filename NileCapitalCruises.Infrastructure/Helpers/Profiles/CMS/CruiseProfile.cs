using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.DiningDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.DiningDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.CMS
{
    public class CruiseProfile : Profile
    {
        public CruiseProfile()
        {
            CreateMap<CruiseRequestDto, Cruise>();
            CreateMap<Cruise, BasicCruiseResponseDto>();
            CreateMap<Cruise, CruiseWithContentResponseDto>()
               .AfterMap((src, dest) =>
               {
                   if (src.CruiseContents.Count > 0)
                       MapperExtensions.MapProperties(src.CruiseContents.FirstOrDefault(), dest);
               }); ;

            //CreateMap<CompanyUserCruiseRequestDto, CompanyUserCruise>();

            ////
            CreateMap<CruiseContent, BasicCruiseResponseDto>();
            CreateMap<CruisePhoto, CruisePhotoResponseDto>();




            //CreateMap<Cruise, BasicCruisesResponseDto>()
            //    .ForMember(dest => dest.CruiseId, opt => opt.MapFrom(src => src.Id))
            //    .AfterMap((src, dest) => {
            //        if(src.CruiseContents.Count > 0)
            //            MapperExtensions.MapProperties(src.CruiseContents.FirstOrDefault(), dest);
            //    });



            // For Photos

            CreateMap<CruisePhotoRequestDto, CruisePhoto>();
            CreateMap<CruisePhoto, CruisePhotoResponseDto>();

            CreateMap<Cruise, CruisesResponseDto>()
                .ForMember(dest => dest.Photos, opt => opt.MapFrom(src => src.CruisePhotos))
                .AfterMap((src, dest) =>
                {
                    MapperExtensions.MapProperties(src.CruiseContents.FirstOrDefault(), dest);
                });


            /// Start Cruise Content

            CreateMap<CruiseContent, CruiseContentResponseDto>();
            CreateMap<CruiseContentRequestDto, CruiseContent>();

        }
    }
}
