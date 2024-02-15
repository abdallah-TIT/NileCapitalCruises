namespace NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.CabinTypeCruiseDtos
{
    public class CabinTypeCruiseWithContentAndOrderDetailsResponseDto
    {
        public int CruiseId { get; set; }
        public string CruiseNameSys { get; set; }
        public string CruiseName { get; set; }
        public string CruiseMainPhoto { get; set; }
        public int? CruiseMainPhotoHieght { get; set; }
        public int? CruiseMainPhotoWidth { get; set; }


        public int ItineraryTypeId { get; set; }
        public string? ItineraryTypeNameSys { get; set; }
        public string? ItineraryTypeName { get; set; }

        public int MaximumAdults { get; set; }
        public int MaximumChildren { get; set; }


        public virtual IReadOnlyList<CabinTypeCruiseWithContentResponseDto> CabinTypeCruiseWithContents { get; set; }
    }
}
