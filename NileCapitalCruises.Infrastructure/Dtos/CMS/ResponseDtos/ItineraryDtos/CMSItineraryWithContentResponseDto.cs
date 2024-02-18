using NileCapitalCruises.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.ItineraryDtos
{
    public class CMSItineraryWithContentResponseDto
    {
        public int ItineraryId { get; set; }

        public string? ItineraryNameSys { get; set; }
        public int? DurationId { get; set; }
        public int? Days { get; set; }
        public int? Nights { get; set; }

        public int? CompanyId { get; set; }
        public string CompanyNameSys { get; set; }
        public string CompanyName { get; set; }

        public string? ItineraryUrl { get; set; }
        public string? ItineraryMap { get; set; }

        public int? CruiseId { get; set; }
        public string CruiseNameSys { get; set; }
        public string CruiseName { get; set; }
        public int? ItineraryTypeId { get; set; }
        public string ItineraryTypeNameSys { get; set; }
        public string ItineraryTypeName { get; set; }

        public int? WeekDayId { get; set; }
        public string? WeekDayNameSys { get; set; }
        public string? WeekDayName { get; set; }

        public bool? ItineraryStatus { get; set; }


        public int? CityFromId { get; set; }
        public string? CityFromNameSys { get; set; }
        public string? CityFromName { get; set; }
        public int? CityToId { get; set; }
        public string? CityToNameSys { get; set; }
        public string? CityToName { get; set; }



        /// Start Content

        public string? ItineraryName { get; set; }

        public int? LanguageId { get; set; }

     
        public string? Intro { get; set; }
        public string? Details { get; set; }



    }
}
