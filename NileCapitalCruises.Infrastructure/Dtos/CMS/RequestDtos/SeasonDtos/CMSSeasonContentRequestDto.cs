using NileCapitalCruises.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.SeasonDtos
{
    public class CMSSeasonContentRequestDto
    {
        public bool? ContentLangStatus { get; set; }
        [MaxLength(150)]
        public string? SeasonName { get; set; }

    }
}
