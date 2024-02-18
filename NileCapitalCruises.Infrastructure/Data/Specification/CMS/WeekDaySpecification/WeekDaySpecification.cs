using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.WeekDaySpecification
{
    public class WeekDaySpecification : BaseSpecification<WeekDay>
    {
        private readonly IMapper _mapper;

        public WeekDaySpecification(PaginationSpecParams paginationSpecParams) : base(
            x => x.IsDeleted == false
            )
        {
            ApplyPaging(paginationSpecParams.PageSize * (paginationSpecParams.PageIndex - 1), paginationSpecParams.PageSize);
           

        }


       

    }
}
