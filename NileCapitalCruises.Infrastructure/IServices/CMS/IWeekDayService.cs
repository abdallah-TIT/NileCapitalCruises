using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.WeekDayDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;

namespace NileCapitalCruises.Infrastructure.IServices.CMS
{
    public interface IWeekDayService
    {
        Task<IResponse> CreateWeekDay(WeekDayRequestDto requestDto);
        Task<IResponse> GetWeekdays(PaginationSpecParams paginationSpecParams);

    }
}
