using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.DurationDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;

namespace NileCapitalCruises.Infrastructure.IServices.CMS
{
    public interface CMSIDurationService
    {
        Task<IResponse> CreateDuration(DurationRequestDto requestDto);
       
    }
}
