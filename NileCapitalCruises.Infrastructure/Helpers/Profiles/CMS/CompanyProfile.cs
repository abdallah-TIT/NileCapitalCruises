using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.ItineraryDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.ItineraryDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.ItineraryTypeDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.CMS
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            /// Start Company
            CreateMap<CompanyRequestDto, Company>();
            CreateMap<Company, BasicCompanyResponseDto>();
            CreateMap<Company, CompanyWithContentResponseDto>().ForMember(dest => dest.CompanyId, opt => opt.MapFrom(src => src.Id))
                .AfterMap((src, dest) =>
                {
                    if (src.CompanyContents.Count > 0)
                        MapperExtensions.MapProperties(src.CompanyContents.FirstOrDefault(), dest);
                }); ;

            /// Start Company Content

            CreateMap<CompanyContent, CompanyContentResponseDto>();
            CreateMap<CompanyContentRequestDto, CompanyContent>();
        }
    }
}
