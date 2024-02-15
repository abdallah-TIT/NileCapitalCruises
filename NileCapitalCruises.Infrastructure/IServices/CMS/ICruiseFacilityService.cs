using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinAmenityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseFacilityDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;

namespace NileCapitalCruises.Infrastructure.IServices.CMS
{
    public interface ICruiseFacilityService
    {
        Task<IResponse> UpdateFacilitiesToCruise(int cruiseId, int companyId, IEnumerable<CruiseFacilityRequestDto> requestDto);

        Task<IResponse> GetFacilities(int cruiseId, string languageCode = "en");


    }
}
