
namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.PeriodDtos
{
    public class CMSBasicPeriodResponseDto
    {
        public int PeriodId { get; set; }
        public string? PeriodNameSys { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public int? CruiseId { get; set; }
        public int? SeasonId { get; set; }
    }
}
