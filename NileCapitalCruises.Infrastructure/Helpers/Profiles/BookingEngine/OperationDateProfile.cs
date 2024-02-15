using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.OperationDateDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.BookingEngine
{
    public class OperationDateProfile : Profile
    {
        public OperationDateProfile()
        {
            /// Start OperationDate
          
            CreateMap<OperationDate, BEBasicOperationDateResponseDto>().
                ForMember(dest => dest.DayName, opt => opt.MapFrom(src => src.WeekDay.WeekDayNameSys)).
                ForMember(dest => dest.DayCode, opt => opt.MapFrom(src => src.WeekDay.DayCode));
        }
    }
}
