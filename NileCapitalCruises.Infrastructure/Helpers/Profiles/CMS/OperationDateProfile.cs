using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.OperationDateDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CabinTypeCruiseOperationDateDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.OperationDateDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.CMS
{
    public class OperationDateProfile : Profile
    {
        public OperationDateProfile()
        {
            /// Start OperationDate
            CreateMap<OperationDateRequestDto, OperationDate>();
            CreateMap<OperationDate, BasicOperationDateResponseDto>()
                .ForMember(dest => dest.CabinTypeCruiseOperationDates, opt => opt.MapFrom(src => src.CabinTypeCruiseOperationDates));
        }
    }
}
