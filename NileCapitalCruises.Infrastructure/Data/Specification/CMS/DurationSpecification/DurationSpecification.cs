using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.DurationSpecification
{
    public class DurationSpecification : BaseSpecification<Duration>
    {
        private readonly IMapper _mapper;

        public DurationSpecification(PaginationSpecParams paginationSpecParams) : base(
            x => x.IsDeleted == false
            )
        {
            ApplyPaging(paginationSpecParams.PageSize * (paginationSpecParams.PageIndex - 1), paginationSpecParams.PageSize);
           

        }


       

    }
}
