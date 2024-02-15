
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseDtos;
using Microsoft.AspNetCore.JsonPatch;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using Microsoft.AspNetCore.Http;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyDtos;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyUserCruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseCategoryDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.DiningDtos;

namespace NileCapitalCruises.Infrastructure.IServices.CMS
{
    public interface ICruiseService
    {
        Task<IResponse> GetCruises(int companyId, PaginationSpecParams paginationSpecParams);
        Task<IResponse> GetCruise(int cruiseId, int companyId);
        Task<IResponse> GetCruiseContent(int cruiseId, int companyId, string languageCode = "en");

        Task<IResponse> UpdateCruiseContent(int cruiseId, int companyId, CruiseContentRequestDto requestDto, string languageCode = "en");

        //Task<IResponse> UpdateCruisePhotos(int cruiseId, int companyId, IEnumerable<CruisePhotoRequestDto> requestDto);
        Task<IResponse> CreateCruisePhotos(int cruiseId, int companyId, IEnumerable<CruisePhotoRequestDto> requestDto);
        Task<IResponse> DeleteCruisePhoto(int photoId, int companyId);
        Task<IResponse> GetCruisePhotos(int cruiseId, int companyId);
        Task<IResponse> GetCruiseByUrlName(string cruiseUrl, string languageCode = "en");
        Task<IResponse> CreateCruise(CruiseRequestDto requestDto, int companyId);
        Task<IResponse> UpdateCruise(int cruiseId, int companyId, CruiseRequestDto requestDto);
        Task<IResponse> DeleteCruise(int cruiseId, int companyId);
        Task<IResponse> UpdatePatchCruise(int id, JsonPatchDocument model);
        Task<IResponse> UpdatePatchCruiseContent(int id, string languageCode, JsonPatchDocument model);

        Task<bool> IsAvailableAsync(int cruiseId, int companyId);

        //Task<IResponse> RemoveCruiseFromUser(int companyId, CruiseToUserRequestDto requestDto);

        Task<IResponse> DeleteCruisePhotos(int cruiseId, int companyId);
    }
}
