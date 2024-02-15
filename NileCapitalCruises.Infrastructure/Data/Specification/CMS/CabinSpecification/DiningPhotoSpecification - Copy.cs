using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.CabinSpecification
{
    public class CabinPhotoSpecification : BaseSpecification<CabinPhoto>
    {


        public CabinPhotoSpecification(int? photoId, int? cabinId) : base(
           x => (!photoId.HasValue || x.Id == photoId) &&
            x.IsDeleted == false
           && (!cabinId.HasValue || x.CabinId == cabinId)
           )

        {
        }
    }
}
