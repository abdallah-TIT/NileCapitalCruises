using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.DiningSpecification
{
    public class DiningPhotoSpecification : BaseSpecification<DiningPhoto>
    {
        

        public DiningPhotoSpecification(int? photoId, int? diningId) : base(
           x => (!photoId.HasValue || x.Id == photoId) &&
            x.IsDeleted == false
           && (!diningId.HasValue || x.DiningId == diningId)
           )

        {
        }
    }
}
