using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyUserCruiseDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;

namespace NileCapitalCruises.Infrastructure.IServices.CMS
{
    public interface ICompanyUserCruiseService
    {
        Task<IResponse> AssignCruiseToUser(int companyId, CompanyUserCruiseRequestDto requestDto);
        Task<IResponse> RemoveCruiseFromUser(int companyId, CompanyUserCruiseRequestDto requestDto);

        Task<IResponse> GetCruisesForUser(int companyUserId, int companyId, PaginationSpecParams paginationSpecParams);

        Task<IResponse> GetUsersForCruise(int cruiseId, int companyId, PaginationSpecParams paginationSpecParams);

        //Task<(List<CompanyUserCruiseRequestDto> existingItems, List<CompanyUserCruise> createdItems)> AssignCruiseToUserTest(IEnumerable<CompanyUserCruiseRequestDto> cruiseRequests);
    }
}
