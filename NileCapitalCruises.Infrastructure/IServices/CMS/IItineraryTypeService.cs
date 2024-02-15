using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.ItineraryTypeDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;

namespace NileCapitalCruises.Infrastructure.IServices.CMS
{
    public interface IItineraryTypeService
    {
        Task<IResponse> CreateItineraryType(CMSItineraryTypeRequestDto requestDto);
        Task<IResponse> UpdateItineraryType(int itineraryTypeId, CMSItineraryTypeRequestDto requestDto);
        Task<IResponse> GetItineraryTypes(PaginationSpecParams paginationSpecParams);
        Task<IResponse> GetItineraryType(int itineraryTypesId);

        Task<IResponse> DeleteItineraryType(int itineraryTypeId);

        Task<IResponse> GetItineraryTypeContents(int itineraryTypeId);
        Task<IResponse> GetItineraryTypeContent(int itineraryTypeId, string languageCode = "en");

        Task<IResponse> UpdateItineraryTypeContent(int itineraryTypeId, CMSItineraryTypeContentRequestDto requestDto, string languageCode = "en");
    }
}
