using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.WeekDayDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;

namespace NileCapitalCruises.Infrastructure.IServices.CMS
{
    public interface IWeekDayService
    {
        Task<IResponse> CreateWeekDay(WeekDayRequestDto requestDto);
       
    }
}
