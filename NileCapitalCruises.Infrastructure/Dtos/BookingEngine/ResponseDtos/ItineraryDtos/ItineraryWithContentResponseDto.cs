namespace NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.ItineraryDtos
{
    public class ItineraryWithContentResponseDto
    {
        public int ItineraryTypeId { get; set; }

        public int ItineraryId { get; set; }
        public string ItineraryNameSys { get; set; }
        public string ItineraryName { get; set; }
        public string? ItineraryMap { get; set; }
        public string? Intro { get; set; }

        public string? Details { get; set; }
        public int CruiseId { get; set; }
        public string CruiseNameSys { get; set; }
        public string CruiseName { get; set; }
        public string CruiseMainPhoto { get; set; }
        public int? CruiseMainPhotoHieght { get; set; }
        public int? CruiseMainPhotoWidth { get; set; }

        public string? CruiseIntro { get; set; }
        public string? CruiseDetails { get; set; }

        public int LowerPrice { get; set; }

        public virtual IReadOnlyList<BECruisePhotoResponseDto> CruisePhotos { get; set; }





    }
}
