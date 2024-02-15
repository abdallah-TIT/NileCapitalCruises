
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.DiningTypeDtos
{
    public class DiningTypeWithContentResponseDto
    {
        public int DiningTypeId { get; set; }
        public string? DiningTypeNameSys { get; set; }

       
        public string? DiningTypeUrl { get; set; }



        ////

        public string? DiningTypeName { get; set; }

        public int? LanguageId { get; set; }


        public bool? ContentLangStatus { get; set; }



    }
}
