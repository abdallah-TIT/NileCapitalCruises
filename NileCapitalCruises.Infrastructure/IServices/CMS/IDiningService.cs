using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.DiningDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;

namespace NileCapitalCruises.Infrastructure.IServices.CMS
{
    public interface IDiningService
    {
        Task<IResponse> CreateDining(int companyId, CreateDiningRequestDto requestDto);

        Task<IResponse> UpdateDining(int diningId, int companyId, UpdateDiningRequestDto requestDto);

        Task<IResponse> DeleteDining(int companyId, int diningId);

        Task<IResponse> GetDinings(PaginationSpecParams paginationSpecParams, int cruiseId, int companyId);

        Task<IResponse> GetDining(int diningId, int companyId);


        Task<IResponse> GetDiningContent(int diningId, int companyId, string languageCode = "en");

        Task<IResponse> UpdateDiningContent(int diningId, int companyId, DiningContentRequestDto requestDto, string languageCode = "en");

        Task<IResponse> GetDiningPhotos(int diningId, int companyId);

        Task<IResponse> CreateDiningPhotos(int diningId, int companyId, IEnumerable<DiningPhotoRequestDto> requestDto);

        Task<IResponse> DeleteDiningPhoto(int photoId, int companyId);

        Task<IResponse> DeleteDiningPhotos(int diningId, int companyId);
    }
}
