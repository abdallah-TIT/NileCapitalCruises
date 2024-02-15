using NileCapitalCruises.Core.Models;
using System.Text.Json.Serialization;

namespace NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.OperationDateDtos
{
    public class BEBasicOperationDateResponseDto
    {
        
        public int Id { get; set; }
        public int? DayCode { get; set; }
        public string? DayName { get; set; }
        public int? OperationDay { get; set; }
        public int? OperationMonth { get; set; }
        public int? OperationYear { get; set; }
        public DateTime? Operation_Date { get; set; }


        [JsonIgnore]
        public virtual Itinerary? Itinerary { get; set; }

        public string OperationDate
        {
            get
            {
                if (OperationDay.HasValue && OperationMonth.HasValue && OperationYear.HasValue)
                {
                    return $"{OperationYear:D4},{OperationMonth:D2},{OperationDay:D2}";
                }
                else
                {
                    return string.Empty; // or any default value you prefer
                }
            }
        }



    }
}
