using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.WeekDayDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.WeekDayDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.CMS
{
    public class WeekDayProfile : Profile
    {
        public WeekDayProfile()
        {
            /// Start WeekDay
            CreateMap<WeekDayRequestDto, WeekDay>();
            CreateMap<WeekDay, BasicWeekDayResponseDto>();
        }
    }
}
