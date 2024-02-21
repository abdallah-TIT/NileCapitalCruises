using NileCapitalCruises.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.ItineraryTypeDtos
{
    public class CMSItineraryTypeContentRequestDto
    {
        [MaxLength(150)]
        public string? ItineraryTypeName { get; set; }

        public bool? ContentLangStatus { get; set; } 

    }
}
