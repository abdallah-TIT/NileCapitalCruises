using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.AmenityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;

namespace NileCapitalCruises.Infrastructure.IServices.CMS
{
    public interface ICabinService
    {
        Task<IResponse> CreateCabin(CabinRequestDto requestDto, int companyId);
        Task<IResponse> UpdateCabin(int cabinId, int companyId, CabinRequestDto requestDto);

        Task<IResponse> DeleteCabin(int cabinId, int companyId);

        Task<IResponse> GetCabins(int cruiseId, int companyId, PaginationSpecParams paginationSpecParams);
        Task<IResponse> GetCabin(int cabinId, int companyId);
        Task<IResponse> GetCabinContent(int cabinId, int companyId, string languageCode = "en");
        Task<IResponse> UpdateCabinContent(int cabinId, int companyId, CabinContentRequestDto requestDto, string languageCode = "en");

        Task<IResponse> GetCabinPhotos(int cabinId, int companyId);

        Task<IResponse> CreateCabinPhotos(int cabinId, int companyId, IEnumerable<CabinPhotoRequestDto> requestDto);
        Task<IResponse> DeleteCabinPhoto(int photoId, int companyId);

        Task<IResponse> DeleteCabinPhotos(int cabinId, int companyId);
    }
}
