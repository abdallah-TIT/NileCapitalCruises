using AutoMapper;
using NileCapitalCruises.Core.ApiModels;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyUserDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.CMS
{
    public class CompanyUserProfile : Profile
    {

        public CompanyUserProfile()
        {

            /// Start Company
            CreateMap<CompanyUserRequestDto, CompanyUser>();
            CreateMap<CompanyUserUpdateRequestDto, CompanyUser>();

            CreateMap<CompanyUser, CompanyUserResponseDto>()
               .AfterMap((src, dest) =>
               {
                   if (src.User != null)
                   {
                       MapperExtensions.MapProperties(src.User, dest);

                   }
                   dest.Id = src.Id;
               }); ;

        }
    }
}
