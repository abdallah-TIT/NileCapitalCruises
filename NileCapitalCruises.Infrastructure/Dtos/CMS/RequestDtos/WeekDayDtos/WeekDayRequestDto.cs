using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.WeekDayDtos
{
    public class WeekDayRequestDto
    {
        [Required]
        public int DayCode { get; set; }
        [Required]
        [MaxLength(150)]
        public string? WeekDayNameSys { get; set; }
    }
}
