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
        public int? CompanyId { get; set; }

        public string? ItineraryUrl { get; set; }
        public string? ItineraryMap { get; set; }

        public int? CruiseId { get; set; }
        public int? ItineraryTypeId { get; set; }

        public int? WeekDayId { get; set; }

        public bool? ItineraryStatus { get; set; }


        public int? CityFromId { get; set; }
        public int? CityToId { get; set; }



        /// Start Content

        public string? ItineraryName { get; set; }

        public int? LanguageId { get; set; }

     
        public string? Intro { get; set; }
        public string? Details { get; set; }



    }
}
