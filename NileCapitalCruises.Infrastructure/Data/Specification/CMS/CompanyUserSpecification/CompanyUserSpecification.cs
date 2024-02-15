using AutoMapper;
using NileCapitalCruises.Core.ApiModels;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.CompanyUserSpecification
{
    public class CompanyUserSpecification : BaseSpecification<CompanyUser>
    {
        private readonly IMapper _mapper;

        //public CompanyUserSpecification(PaginationSpecParams paginationSpecParams,int companyId) : base(
        //    x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.CompanyUserName.ToLower().Contains(paginationSpecParams.Search)) && x.IsDeleted == false && x.CompanyId == companyId
        //    )
        //{
        //    ApplyPaging(paginationSpecParams.PageSize * (paginationSpecParams.PageIndex - 1), paginationSpecParams.PageSize);
        //    AddInclude(x => x.User);

        //}


        public CompanyUserSpecification(PaginationSpecParams paginationSpecParams, int companyId, int? cruiseId = null) : base(
            x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.CompanyUserName.ToLower().Contains(paginationSpecParams.Search)) && (x.IsDeleted == false) && (x.CompanyId == companyId) && (!cruiseId.HasValue || x.CompanyUserCruises.Any(ccu => ccu.CruiseId == cruiseId && ccu.IsDeleted == false)))
        {
            ApplyPaging(paginationSpecParams.PageSize * (paginationSpecParams.PageIndex - 1), paginationSpecParams.PageSize);


            //AddInclude(x => x.CompanyUserCruises);
            AddInclude(x => x.User);
        }

        public CompanyUserSpecification(int companyUserId, int companyId) : base(x => x.CompanyId == companyId && x.IsDeleted == false && x.Id == companyUserId)
        {
            AddInclude(x => x.User);
        }

        //public CruiseSpecification(string cruiseUrl) : base(x => x.CruiseUrl == cruiseUrl)
        //{
        //}
    }
}
