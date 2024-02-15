using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CityDtos
{
    public class CityRequestDto
    {
        [MaxLength(150)]
        public string? CityNameSys { get; set; }
       
        [MaxLength(250)]
        public string? CityPhoto { get; set; }
        [MaxLength(250)]
        public string? CityBanner { get; set; }
        public bool? CityStatus { get; set; }
        public int? CityPhotoWidth { get; set; }
        public int? CityPhotoHeight { get; set; }
        public int? CityBannerWidth { get; set; }
        public int? CityBannerHeight { get; set; }

    }
}
