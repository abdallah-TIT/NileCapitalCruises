namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CabinAmenityDtos
{
    public class AmenityResponseDto
    {
        public int AmenityId { get; set; }

        public string? AmenityNameSys { get; set; }
        public string? AmenityIcon { get; set; }
        public int? AmenityPosition { get; set; }
        public int? AmenityIconWidth { get; set; }
        public int? AmenityIconHeight { get; set; }

        public string? AmenityUrl { get; set; }
        public bool? Status { get; set; }
        ///

        public bool? ContentLangStatus { get; set; }
        public string? AmenityName { get; set; }
    }
}
