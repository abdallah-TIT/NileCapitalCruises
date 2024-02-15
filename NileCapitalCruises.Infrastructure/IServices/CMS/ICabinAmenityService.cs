using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinAmenityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseFacilityDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;

namespace NileCapitalCruises.Infrastructure.IServices.CMS
{
    public interface ICabinAmenityService
    {
        Task<IResponse> UpdateAmenitiesToCabin(int cabinId, int companyId, IEnumerable<CabinAmenityRequestDto> requestDto);

        Task<IResponse> GetAmenities(int cabinId, string languageCode = "en");
    }
}
