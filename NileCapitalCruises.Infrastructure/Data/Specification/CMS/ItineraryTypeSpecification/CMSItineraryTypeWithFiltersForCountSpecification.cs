using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.ItineraryTypeSpecification
{
    public class CMSItineraryTypeWithFiltersForCountSpecification : BaseSpecification<ItineraryType>
    {
        public CMSItineraryTypeWithFiltersForCountSpecification(PaginationSpecParams paginationSpecParams) : base(
            x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.ItineraryTypeNameSys.ToLower().Contains(paginationSpecParams.Search)) && x.IsDeleted == false
            )
        {
        }
    }

}
