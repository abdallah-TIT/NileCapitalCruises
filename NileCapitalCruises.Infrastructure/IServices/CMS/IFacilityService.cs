using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseFacilityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.FacilityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.ItineraryTypeDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;

namespace NileCapitalCruises.Infrastructure.IServices.CMS
{
    public interface IFacilityService
    {
        Task<IResponse> CreateFacility(FacilityRequestDto requestDto);
        Task<IResponse> UpdateFacility(int facilityId, FacilityRequestDto requestDto);
        Task<IResponse> GetFacilities(PaginationSpecParams paginationSpecParams);

        Task<IResponse> GetFacility(int facilityId);

        Task<IResponse> DeleteFacility(int facilityId);


        Task<IResponse> GetFacilityContent(int facilityId, string languageCode = "en");
        Task<IResponse> UpdateFacilityContent(int facilityId, FacilityContentRequestDto requestDto, string languageCode = "en");


    }
}
