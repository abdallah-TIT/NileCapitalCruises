using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Core.Models.Views;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos;
using System.Linq.Expressions;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.OperationDateSpecification
{
    public class CMSOperationDateSpecification : BaseSpecification<OperationDate>
    {
        private readonly IMapper _mapper;

        public CMSOperationDateSpecification(PaginationSpecParams paginationSpecParams, int itineraryId) : base(
            x => x.ItineraryId == itineraryId && x.IsDeleted == false
            )
        {
            ApplyPaging(paginationSpecParams.PageSize * (paginationSpecParams.PageIndex - 1), paginationSpecParams.PageSize);

            //AddInclude(x => x.CabinTypeCruiseOperationDates);
            //AddView(VwOperationDateCabinType);

        }

        



    }
}
