using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos
{
    public class CruisesResponseDto : BasicCruiseResponseDto
    {
        public ICollection<CruisePhotoResponseDto> Photos { get; set; }
    }
}
