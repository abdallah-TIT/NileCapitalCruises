using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinDtos
{
    public class CabinPhotoRequestDto
    {
        [Required]
        public int? CabinId { get; set; }

        [Required]
        [MaxLength(250)]
        public string? PhotoFile { get; set; }
        public int? PhotoPosition { get; set; }
        public bool? PhotoStatus { get; set; }
        public int? PhotoHieght { get; set; }
        public int? PhotoWidth { get; set; }

    }
}
