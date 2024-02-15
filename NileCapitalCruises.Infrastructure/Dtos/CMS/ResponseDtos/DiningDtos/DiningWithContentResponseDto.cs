

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.DiningDtos
{
    public class DiningWithContentResponseDto
    {
        public int DiningId { get; set; }


        public int? CruiseId { get; set; }
        
        public string? DiningNameSys { get; set; }
        public string? DiningHours { get; set; }

        
        public string? DressCode { get; set; }
        public string? DiningCuisine { get; set; }
        public string? DiningOpenFor { get; set; }
        public string? DiningMenu { get; set; }
        public string? DiningFolderName { get; set; }
        public string? DiningPhoto { get; set; }

        public int? DiningTypeId { get; set; }
        public string? DiningUrl { get; set; }

        public bool? Status { get; set; }



        ////
        ///


        public int? LanguageId { get; set; }
        public bool? ContentLangStatus { get; set; }

        public string? DiningName { get; set; }

        
        public string? DiningDescription { get; set; }
    }
}
