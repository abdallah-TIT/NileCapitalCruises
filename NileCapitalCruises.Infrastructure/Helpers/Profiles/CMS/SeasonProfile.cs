using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.SeasonDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.SeasonDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.CMS
{
    public class SeasonProfile : Profile
    {
        public SeasonProfile()
        {
            /// Start Season
            CreateMap<CMSSeasonRequestDto, Season>();
            CreateMap<Season, CMSBasicSeasonResponseDto>()
            .ForMember(dest => dest.SeasonId, opt => opt.MapFrom(src => src.Id));
            CreateMap<Season, CMSSeasonWithContentResponseDto>().ForMember(dest => dest.SeasonId, opt => opt.MapFrom(src => src.Id))
              .AfterMap((src, dest) =>
              {
                  if (src.SeasonContents.Count > 0)
                      MapperExtensions.MapProperties(src.SeasonContents.FirstOrDefault(), dest);
              });


            /// Start Season Content

            CreateMap<SeasonContent, CMSSeasonContentResponseDto>()
                .ForMember(dest => dest.SeasonContentId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.SeasonId, opt => opt.MapFrom(src => src.OriginalTableId));

            CreateMap<CMSSeasonContentRequestDto, SeasonContent>();
        }
    }
}
