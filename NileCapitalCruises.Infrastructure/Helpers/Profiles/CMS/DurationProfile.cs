using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.DurationDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.DurationDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.CMS
{
    public class DurationProfile : Profile
    {
        public DurationProfile()
        {
            /// Start Duration
            CreateMap<DurationRequestDto, Duration>();
            CreateMap<Duration, BasicDurationResponseDto>();
        }
    }
}
