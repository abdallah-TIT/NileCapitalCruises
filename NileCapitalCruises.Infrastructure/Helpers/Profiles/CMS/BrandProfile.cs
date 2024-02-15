using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.BrandDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.BrandDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.CMS
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            /// Start Brand
            CreateMap<CMSBrandRequestDto, Brand>();
            CreateMap<Brand, CMSBasicBrandResponseDto>()
                 .ForMember(dest => dest.BrandId, opt => opt.MapFrom(src => src.Id));

            CreateMap<Brand, CMSBrandWithContentResponseDto>().ForMember(dest => dest.BrandId, opt => opt.MapFrom(src => src.Id))
              .AfterMap((src, dest) =>
              {
                  if (src.BrandContents.Count > 0)
                      MapperExtensions.MapProperties(src.BrandContents.FirstOrDefault(), dest);
              });


            /// Start Brand Content

            CreateMap<BrandContent, CMSBrandContentResponseDto>()
                .ForMember(dest => dest.BrandContentId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.BrandId, opt => opt.MapFrom(src => src.OriginalTableId));
            CreateMap<CMSBrandContentRequestDto, BrandContent>();
        }
    }
}
