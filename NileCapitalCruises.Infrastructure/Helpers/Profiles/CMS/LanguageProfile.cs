using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.DiningTypeDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.LanguageDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.OperationDateDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.WeekDayDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.DiningTypeDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.LanguageDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.OperationDateDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.WeekDayDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.CMS
{
    public class LanguageProfile : Profile
    {
        public LanguageProfile()
        {
            CreateMap<CMSLanguageRequestDto, Language>();
            CreateMap<Language, CMSBasicLanguageResponseDto>()
                .ForMember(dest => dest.LanguageId, opt => opt.MapFrom(src => src.Id));
        }
    }
}
