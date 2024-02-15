using AutoMapper;
using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.AmenitySpecification
{

    public class AmenitySpecification : BaseSpecification<Amenity>
    {
        private readonly IMapper _mapper;

        public AmenitySpecification(PaginationSpecParams paginationSpecParams) : base(
            x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.AmenityNameSys.ToLower().Contains(paginationSpecParams.Search)) && x.IsDeleted == false
            )
        {
            ApplyPaging(paginationSpecParams.PageSize * (paginationSpecParams.PageIndex - 1), paginationSpecParams.PageSize);
            AddInclude(x => x.AmenityContents.Where(c => c.Language.LanguageAbbreviation == paginationSpecParams.LanguageCode));

        }


        public AmenitySpecification(int amenityId) : base(x => x.Id == amenityId && x.IsDeleted == false)
        {

        }

  


    }
}
