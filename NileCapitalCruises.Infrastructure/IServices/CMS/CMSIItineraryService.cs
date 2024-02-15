using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.ItineraryDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.ItineraryTypeDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;

namespace NileCapitalCruises.Infrastructure.IServices.CMS
{
    public interface CMSIItineraryService
    {
        Task<IResponse> CreateItinerary(int companyId, CMSItineraryRequestDto requestDto);
        Task<IResponse> UpdateItinerary(int itineraryId, int companyId, CMSItineraryRequestDto requestDto);
        Task<IResponse> GetItineraries(int cruiseId, PaginationSpecParams paginationSpecParams);
        Task<IResponse> GetItinerary(int itineraryId);

        Task<IResponse> DeleteItinerary(int itineraryId);

        Task<IResponse> GetItineraryContent(int itineraryId, string languageCode = "en");
        Task<IResponse> UpdateItineraryContent(int itineraryId, CMSItineraryContentRequestDto requestDto, string languageCode = "en");
    }
}
