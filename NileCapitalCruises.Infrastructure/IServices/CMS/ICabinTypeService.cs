using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinTypeDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;


namespace NileCapitalCruises.Infrastructure.IServices.CMS
{
    public interface ICabinTypeService
    {
        Task<IResponse> CreateCabinType(CabinTypeRequestDto requestDto);

        Task<IResponse> UpdateCabinType(int cabinTypeId, CabinTypeRequestDto requestDto);

        Task<IResponse> GetCabinTypes(PaginationSpecParams paginationSpecParams);

        Task<IResponse> GetCabinType(int cabinTypeId);

        Task<IResponse> DeleteCabinType(int cabinTypeId);


        Task<IResponse> GetCabinTypeContent(int cabinTypeId, string languageCode = "en");

        Task<IResponse> UpdateCabinTypeContent(int cabinTypeId, CabinTypeContentRequestDto requestDto, string languageCode = "en");
    }
}
