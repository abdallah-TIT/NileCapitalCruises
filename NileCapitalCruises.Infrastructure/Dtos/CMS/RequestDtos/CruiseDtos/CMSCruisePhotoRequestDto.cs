using NileCapitalCruises.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseDtos
{
    public class CMSCruisePhotoRequestDto
    {
        [Required]
        public int? CruiseId { get; set; }

        [Required]
        [MaxLength(250)]
        public string? PhotoFile { get; set; }
        public int? PhotoPosition { get; set; }
        public bool? PhotoStatus { get; set; }
        public int? PhotoHieght { get; set; }
        public int? PhotoWidth { get; set; }
        
    }
}
