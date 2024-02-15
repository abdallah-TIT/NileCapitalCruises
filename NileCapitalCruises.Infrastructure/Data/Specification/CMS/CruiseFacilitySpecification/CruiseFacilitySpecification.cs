using AutoMapper;
using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.CruiseFacilitySpecification
{
    public class CruiseFacilitySpecification : BaseSpecification<CruiseFacility>
    {

        public CruiseFacilitySpecification(int cruiseId) : base(x => x.CruiseId == cruiseId && x.IsDeleted == false)
        {
           
        }
        public CruiseFacilitySpecification(int cruiseId, string languageCode) : base(x => x.CruiseId == cruiseId && x.IsDeleted == false)
        {
            AddInclude(x => x.Facility);
            AddInclude(x => x.Facility.FacilityContents.Where(c => c.Language.LanguageAbbreviation == languageCode));
        }


        public CruiseFacilitySpecification(int cruiseId,int facilityId) : base(x => x.CruiseId == cruiseId && x.FacilityId == facilityId && x.IsDeleted == false)
        {

        }


    }
}
