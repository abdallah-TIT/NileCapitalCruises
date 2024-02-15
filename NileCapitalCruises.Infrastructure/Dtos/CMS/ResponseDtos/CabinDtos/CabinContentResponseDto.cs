
using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CabinDtos
{
    public class CabinContentResponseDto
    {
        public int Id { get; set; }
        public int? OriginalTableId { get; set; }


        /////  
        ///


        public bool? ContentLangStatus { get; set; }
        public string? CabinName { get; set; }

        public string? CabinDetails { get; set; }
        public string? CabinIntro { get; set; }

        public int? LanguageId { get; set; }

    }
}
