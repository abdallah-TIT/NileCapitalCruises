using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyUserCruiseDtos;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles.CMS
{
    public class CompanyUserCruiseProfile : Profile
    {
        public CompanyUserCruiseProfile()
        {


            CreateMap<CompanyUserCruiseRequestDto, CompanyUserCruise>();



        }
    }
}
