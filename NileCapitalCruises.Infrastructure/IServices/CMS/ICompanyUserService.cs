using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyUserDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;

namespace NileCapitalCruises.Infrastructure.IServices.CMS
{
    public interface ICompanyUserService
    {
        //Task<IResponse> CreateCompanyUserAdmin(CompanyUserRequestDto requestDto);
        Task<IResponse> CreateCompanyUser(CompanyUserRequestDto requestDto);
        Task<IResponse> GetCompanyUsers(PaginationSpecParams paginationSpecParams, int companyId);

        Task<IResponse> GetCompanyUser(int companyId, int companyUserId);
        Task<IResponse> AssignRole(RoleRequestDto assignRoleDto);
        Task<IResponse> RemoveRole(RoleRequestDto removeRoleDto);

        Task<IResponse> UpdateCompanyUser(int companyId,int companyUserId, CompanyUserUpdateRequestDto requestDto);

        Task<bool> IsAvailableAsync(int companyUserId, int companyId);
    }
}
