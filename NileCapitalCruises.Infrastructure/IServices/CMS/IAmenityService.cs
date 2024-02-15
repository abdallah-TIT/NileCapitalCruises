using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.AmenityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;

namespace NileCapitalCruises.Infrastructure.IServices.CMS
{
    public interface IAmenityService
    {
        Task<IResponse> CreateAmenity(AmenityRequestDto requestDto);
        Task<IResponse> UpdateAmenity(int amenityId, AmenityRequestDto requestDto);
        Task<IResponse> GetAmenities(PaginationSpecParams paginationSpecParams);
        Task<IResponse> GetAmenity(int amenityId);
        Task<IResponse> DeleteAmenity(int amenityId);

        Task<IResponse> GetAmenityContent(int amenityId, string languageCode = "en");

        Task<IResponse> UpdateAmenityContent(int amenityId, AmenityContentRequestDto requestDto, string languageCode = "en");
    }
}
