using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.OperationDateDtos
{
    public class BasicOperationDateResponseDto
    {
        public int? CruiseId { get; set; }
        public int? CompanyId { get; set; }
        public int? WeekDayId { get; set; }
        public int? ItineraryId { get; set; }

        public string? OperationDateUrl { get; set; }

        public DateTime? Operation_Date;
        public int? OperationDay { get; set; }
        public int? OperationMonth { get; set; }
        public int? OperationYear { get; set; }
    }
}
