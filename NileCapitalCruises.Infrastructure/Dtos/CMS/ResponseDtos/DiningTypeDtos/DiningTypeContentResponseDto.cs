
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.DiningTypeDtos
{
    public class DiningTypeContentResponseDto
    {

        public int Id { get; set; }
        public int? OriginalTableId { get; set; }
        public string? DiningTypeName { get; set; }

        public int? LanguageId { get; set; }


        public bool? ContentLangStatus { get; set; }



    }
}
