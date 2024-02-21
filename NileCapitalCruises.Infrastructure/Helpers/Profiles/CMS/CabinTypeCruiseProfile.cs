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

            CreateMap<CabinTypeCruise, CMSCabinTypeCruiseWithContentResponseDto>()
                .ForMember(dest => dest.CabinTypeCruiseId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CabinTypeNameSys, opt => opt.MapFrom(src => src.CabinType.CabinTypeNameSys))
                .ForMember(dest => dest.CabinTypeName, opt => opt.MapFrom(src => src.CabinType.CabinTypeContents.FirstOrDefault().CabinTypeName));


        }
    }
}
