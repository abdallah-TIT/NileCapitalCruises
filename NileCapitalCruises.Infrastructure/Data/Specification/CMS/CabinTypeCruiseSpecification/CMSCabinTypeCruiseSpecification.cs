using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.CabinTypeCruiseSpecification
{
    public class CMSCabinTypeCruiseSpecification : BaseSpecification<CabinTypeCruise>
    {
        private readonly IMapper _mapper;

        public CMSCabinTypeCruiseSpecification(PaginationSpecParams paginationSpecParams,int cruiseId) : base(
            x => x.CruiseId == cruiseId  && x.IsDeleted == false
            )
        {
            ApplyPaging(paginationSpecParams.PageSize * (paginationSpecParams.PageIndex - 1), paginationSpecParams.PageSize);
            AddInclude(x => x.CabinType.CabinTypeContents.Where(c => c.Language.LanguageAbbreviation == paginationSpecParams.LanguageCode));

        }


       
    }
}
