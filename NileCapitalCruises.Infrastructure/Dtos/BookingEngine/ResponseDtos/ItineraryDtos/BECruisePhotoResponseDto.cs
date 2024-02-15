
namespace NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.ItineraryDtos
{
    public class BECruisePhotoResponseDto
    {
        public int Id { get; set; }

        public string? PhotoFile { get; set; }
        public int? PhotoPosition { get; set; }
        public bool? PhotoStatus { get; set; }
        public int? PhotoHieght { get; set; }
        public int? PhotoWidth { get; set; }
    }
}
