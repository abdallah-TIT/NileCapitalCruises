using AutoMapper;
using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.CabinAmenitySpecification
{
    public class CabinAmenitySpecification : BaseSpecification<CabinAmenity>
    {

        public CabinAmenitySpecification(int cabinId) : base(x => x.CabinId == cabinId && x.IsDeleted == false)
        {

        }
        public CabinAmenitySpecification(int cabinId, string languageCode) : base(x => x.CabinId == cabinId && x.IsDeleted == false)
        {
            AddInclude(x => x.Amenity);
            AddInclude(x => x.Amenity.AmenityContents.Where(c => c.Language.LanguageAbbreviation == languageCode));
        }


        public CabinAmenitySpecification(int cabinId, int amenityId) : base(x => x.CabinId == cabinId && x.AmenityId == amenityId && x.IsDeleted == false)
        {

        }


    }
}
