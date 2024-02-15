using NileCapitalCruises.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.ItineraryTypeDtos
{
    public class CMSItineraryTypeWithContentResponseDto
    {
        public int ItineraryTypeId { get; set; }

        public string? ItineraryTypeNameSys { get; set; }
        public int? ItineraryDays { get; set; }
        public int? ItineraryNights { get; set; }

        public int? SailFrom { get; set; }

        public string? ItineraryTypeUrl { get; set; }


        public int? SailTo { get; set; }



        /// Start Content

        public string? ItineraryTypeName { get; set; }

        public int? LanguageId { get; set; }


    }
}
