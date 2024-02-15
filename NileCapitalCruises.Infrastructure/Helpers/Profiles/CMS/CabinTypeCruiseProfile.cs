using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinTypeCruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CabinTypeCruiseDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.CMS
{
    public class CabinTypeCruiseProfile : Profile
    {
        public CabinTypeCruiseProfile()
        {
            CreateMap<CabinTypeCruiseRequestDto, CabinTypeCruise>();
            CreateMap<CabinTypeCruise, BasicCabinTypeCruiseResponseDto>();

        }
    }
}
