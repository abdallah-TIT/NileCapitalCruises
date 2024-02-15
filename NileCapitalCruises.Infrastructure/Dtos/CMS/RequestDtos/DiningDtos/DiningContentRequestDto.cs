using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.DiningDtos
{
    public class DiningContentRequestDto
    {
        public bool? ContentLangStatus { get; set; }

        [MaxLength(150)]
        public string? DiningName { get; set; }

        [MaxLength(250)]
        public string? DiningDescription { get; set; }



    }
}
