using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.PeriodDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;

namespace NileCapitalCruises.Infrastructure.IServices.CMS
{
    public interface IPeriodService
    {
        Task<IResponse> CreatePeriod(CMSPeriodRequestDto requestDto, int seasonId, int cruiseId);


    }
}
