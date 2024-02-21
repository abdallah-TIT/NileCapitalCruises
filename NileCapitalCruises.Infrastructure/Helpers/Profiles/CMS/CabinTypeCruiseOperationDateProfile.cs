using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CabinTypeCruiseOperationDateDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.CMS
{
    public class CabinTypeCruiseOperationDateProfile : Profile
    {
        public CabinTypeCruiseOperationDateProfile()
        {
            /// Start CabinTypeCruiseOperationDate
            /// 
            CreateMap<CabinTypeCruiseOperationDate, BasicCabinTypeCruiseOperationDateResponseDto>()
                .ForMember(dest => dest.CabinTypeNameSys, opt => opt.MapFrom(src => src.CabinTypeCruise.CabinType.CabinTypeNameSys));
                //.ForMember(dest => dest.CabinTypeName, opt => opt.MapFrom(src => src.CabinTypeCruise.CabinType.CabinTypeName));

        }
    }
}
