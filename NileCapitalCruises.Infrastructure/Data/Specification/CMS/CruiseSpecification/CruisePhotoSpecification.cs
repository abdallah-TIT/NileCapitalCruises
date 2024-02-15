using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.CruiseSpecification
{
    public class CruisePhotoSpecification : BaseSpecification<CruisePhoto>
    {
        //public CruisePhotoSpecification(int cruiseId) : base(
        //    x => x.CruiseId == cruiseId &&
        //     x.IsDeleted == false
        //    )

        //{
        //}

        public CruisePhotoSpecification(int? photoId, int? cruiseId) : base(
           x => (!photoId.HasValue || x.Id == photoId) &&
            x.IsDeleted == false
           && (!cruiseId.HasValue || x.CruiseId == cruiseId)
           )

        {
        }
    }
}
