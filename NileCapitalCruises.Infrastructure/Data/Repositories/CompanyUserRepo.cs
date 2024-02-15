using NileCapitalCruises.Core;
using NileCapitalCruises.Core.ApiModels;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Data.Repositories
{
    public class CompanyUserRepo : ICompanyUserRepo
    {
        private readonly NileCapitalCruisesWSDBContext _context;

        public CompanyUserRepo(NileCapitalCruisesWSDBContext context)
        {
            _context = context;
        }

        public async Task<CompanyUser> CreateCompanyUsersAsync(CompanyUser companyUser)
        {
             await _context.CompanyUsers.AddAsync(companyUser);
            return companyUser;
        }

        public async Task<CompanyUser> GetCompanyUserByIdAsync(int id)
        {
            return await _context.CompanyUsers.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IReadOnlyList<CompanyUser>> GetCompanyUsersAsync()
        {
            return await _context.CompanyUsers.ToListAsync();
        }

        //public async Task<int> CountAsync(ISpecification<CompanyUser> spec)
        //{
        //    return await ApplySpecification(spec).CountAsync();
        //}

        //private IQueryable<CompanyUser> ApplySpecification(ISpecification<CompanyUser> spec)
        //{
        //    return SpecificationEvaluator<CompanyUser>.GetQuery(_context.Set<CompanyUser>().AsQueryable(), spec);
        //}
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
