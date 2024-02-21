using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinTypeCruiseDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;

namespace NileCapitalCruises.Infrastructure.IServices.CMS
{
    public interface ICabinTypeCruiseService
    {
        Task<IResponse> CreateCabinTypeCruise(CabinTypeCruiseRequestDto requestDto, int companyId);
        Task<IResponse> GetCabinTypeCruises(int cruiseId, int companyId, PaginationSpecParams paginationSpecParams);
    }
}
