using NileCapitalCruises.Core.ApiModels;
using NileCapitalCruises.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace NileCapitalCruises.Core.IRepositories
{
    public interface ICompanyUserRepo
    {
        Task<CompanyUser> GetCompanyUserByIdAsync(int id);
        Task<IReadOnlyList<CompanyUser>> GetCompanyUsersAsync();
        Task<CompanyUser> CreateCompanyUsersAsync(CompanyUser companyUser);

        //Task<int> CountAsync(ISpecification<T> spec);
        Task SaveChangesAsync();
    }
}
