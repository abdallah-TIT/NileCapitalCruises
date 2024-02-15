using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.DiningTypeDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;

namespace NileCapitalCruises.Infrastructure.IServices.CMS
{
    public interface IDiningTypeService
    {

        Task<IResponse> CreateDiningType(DiningTypeRequestDto requestDto);
        Task<IResponse> UpdateDiningType(int diningTypeId, DiningTypeRequestDto requestDto);

        Task<IResponse> GetDiningTypes(PaginationSpecParams paginationSpecParams);

        Task<IResponse> GetDiningType(int diningTypeId);
        Task<IResponse> DeleteDiningType(int diningTypeId);

        Task<IResponse> GetDiningTypeContent(int diningTypeId, string languageCode = "en");

        Task<IResponse> UpdateDiningTypeContent(int diningTypeId, DiningTypeContentRequestDto requestDto, string languageCode = "en");
    }
}
