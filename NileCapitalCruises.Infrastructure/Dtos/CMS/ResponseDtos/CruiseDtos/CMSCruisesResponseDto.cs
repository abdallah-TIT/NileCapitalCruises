using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos
{
    public class CMSCruisesResponseDto : CMSBasicCruiseResponseDto
    {
        public ICollection<CMSCruisePhotoResponseDto> Photos { get; set; }
    }
}
