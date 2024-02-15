using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.DiningDtos
{
    public class DiningPhotoRequestDto
    {
        [Required]
        public int? DiningId { get; set; }

        [Required]
        [MaxLength(250)]
        public string PhotoFile { get; set; }
        public int? PhotoPosition { get; set; }
        public bool? PhotoStatus { get; set; }
        public int? PhotoHieght { get; set; }
        public int? PhotoWidth { get; set; }

    }
}
