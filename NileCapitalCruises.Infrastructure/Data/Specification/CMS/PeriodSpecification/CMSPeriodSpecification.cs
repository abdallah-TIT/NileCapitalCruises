using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.PeriodSpecification
{
    public class CMSPeriodSpecification : BaseSpecification<Period>
    {
        private readonly IMapper _mapper;

       

        public CMSPeriodSpecification(DateTime curentDate ) : base(x => x.StartDate <= curentDate && x.EndDate >= curentDate &&
        x.IsDeleted == false)
        {

        }

       
    }
}
