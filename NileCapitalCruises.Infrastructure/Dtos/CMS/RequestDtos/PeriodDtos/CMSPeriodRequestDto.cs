using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.PeriodDtos
{
    public class CMSPeriodRequestDto
    {
        [MaxLength(150)]
        public string? PeriodNameSys { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
