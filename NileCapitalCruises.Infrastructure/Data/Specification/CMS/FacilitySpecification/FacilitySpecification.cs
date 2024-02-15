using AutoMapper;
using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.FacilitySpecification
{
    public class FacilitySpecification : BaseSpecification<Facility>
    {
        private readonly IMapper _mapper;

        public FacilitySpecification(PaginationSpecParams paginationSpecParams) : base(
            x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.FacilityNameSys.ToLower().Contains(paginationSpecParams.Search)) && x.IsDeleted == false
            )
        {
            ApplyPaging(paginationSpecParams.PageSize * (paginationSpecParams.PageIndex - 1), paginationSpecParams.PageSize);
            AddInclude(x => x.FacilityContents.Where(c => c.Language.LanguageAbbreviation == paginationSpecParams.LanguageCode));

        }


        public FacilitySpecification(int facilityId) : base(x => x.Id == facilityId && x.IsDeleted == false)
        {

        }

        
    }
}
