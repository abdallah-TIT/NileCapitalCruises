using AutoMapper;
using NileCapitalCruises.Core.Models;


namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.CompanyUserCruiseSpecification
{
    public class CompanyUserCruiseSpecification : BaseSpecification<CompanyUserCruise>
    {
      
        public CompanyUserCruiseSpecification(int companyUserId, int cruiseId) : base(
            x =>  x.IsDeleted == false && x.CompanyUserId == companyUserId && x.CruiseId == cruiseId)
        {
           
        }

        
    }
}
