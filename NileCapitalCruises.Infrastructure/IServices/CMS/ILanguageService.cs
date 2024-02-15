using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.DiningTypeDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.LanguageDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.OperationDateDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.WeekDayDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;

namespace NileCapitalCruises.Infrastructure.IServices.CMS
{
    public interface ILanguageService
    {
        //Task<IResponse> CreateLanguage(CreateLanguageRequestDto requestDto);
        Task<IResponse> CreateLanguage(CMSLanguageRequestDto requestDto);
        Task<IResponse> GetLanguages();
        Task<IResponse> UpdateLanguage(int languageId, CMSLanguageRequestDto requestDto);
    }
}
