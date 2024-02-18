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
            CreateMap<CMSCruiseRequestDto, Cruise>();
            CreateMap<Cruise, CMSBasicCruiseResponseDto>()
                .ForMember(dest => dest.CruiseId, opt => opt.MapFrom(src => src.Id));
            CreateMap<Cruise, CMSCruiseWithContentResponseDto>().ForMember(dest => dest.CruiseId, opt => opt.MapFrom(src => src.Id))
               .AfterMap((src, dest) =>
               {
                   if (src.CruiseContents.Count > 0)
                       MapperExtensions.MapProperties(src.CruiseContents.FirstOrDefault(), dest);
               }); ;

            //CreateMap<CompanyUserCruiseRequestDto, CompanyUserCruise>();

            ////
            CreateMap<CruiseContent, CMSBasicCruiseResponseDto>();
                
            CreateMap<CruisePhoto, CMSCruisePhotoResponseDto>();




            //CreateMap<Cruise, BasicCruisesResponseDto>()
            //    .ForMember(dest => dest.CruiseId, opt => opt.MapFrom(src => src.Id))
            //    .AfterMap((src, dest) => {
            //        if(src.CruiseContents.Count > 0)
            //            MapperExtensions.MapProperties(src.CruiseContents.FirstOrDefault(), dest);
            //    });



            // For Photos

            CreateMap<CMSCruisePhotoRequestDto, CruisePhoto>();
            CreateMap<CruisePhoto, CMSCruisePhotoResponseDto>();

            CreateMap<Cruise, CMSCruisesResponseDto>()
                .ForMember(dest => dest.Photos, opt => opt.MapFrom(src => src.CruisePhotos))
                .AfterMap((src, dest) =>
                {
                    MapperExtensions.MapProperties(src.CruiseContents.FirstOrDefault(), dest);
                });


            /// Start Cruise Content

            CreateMap<CruiseContent, CMSCruiseContentResponseDto>()
                .ForMember(dest => dest.CruiseContentId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CruiseId, opt => opt.MapFrom(src => src.OriginalTableId));
            CreateMap<CMSCruiseContentRequestDto, CruiseContent>();

        }
    }
}
