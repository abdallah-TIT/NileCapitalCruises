using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.SeasonDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;

namespace NileCapitalCruises.Infrastructure.IServices.CMS
{
    public interface ISeasonService
    {
        Task<IResponse> CreateSeason(CMSSeasonRequestDto requestDto);
        Task<IResponse> UpdateSeason(int seasonId, CMSSeasonRequestDto requestDto);
        Task<IResponse> GetSeasons(PaginationSpecParams paginationSpecParams);

        Task<IResponse> GetSeason(int seasonId);
        Task<IResponse> DeleteSeason(int seasonId);

        Task<IResponse> GetSeasonContent(int seasonId, string languageCode = "en");
        Task<IResponse> GetSeasonContents(int seasonId);
        Task<IResponse> UpdateSeasonContent(int seasonId, CMSSeasonContentRequestDto requestDto, string languageCode = "en");

    }
}
