using NileCapitalCruises.Core.Models;
using System.ComponentModel.Design;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.ItinerarySpecification
{
    public class CMSItineraryWithFiltersForCountSpecification : BaseSpecification<Itinerary>
    {
        public CMSItineraryWithFiltersForCountSpecification(PaginationSpecParams paginationSpecParams, int cruiseId) : base(
            x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.ItineraryNameSys.ToLower().Contains(paginationSpecParams.Search)) && x.IsDeleted == false && x.CruiseId == cruiseId)
        {
        }
    }
}
