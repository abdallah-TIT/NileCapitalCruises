using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.ItineraryDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;

namespace NileCapitalCruises.Infrastructure.IServices.CMS
{
    public interface ICompanyService
    {
        Task<IResponse> CreateCompany(CompanyRequestDto requestDto);
        Task<IResponse> GetCompanies(PaginationSpecParams paginationSpecParams);
        Task<IResponse> GetCompany(int id);
        Task<IResponse> GetCompanyContent(int id, string languageCode = "en");

        Task<IResponse> UpdateCompany(int companyId, CompanyRequestDto requestDto);

        Task<IResponse> UpdateCompanyContent(int companyId, CompanyContentRequestDto requestDto, string languageCode = "en");

        Task<IResponse> DeleteCompany(int companyId);
    }
}
