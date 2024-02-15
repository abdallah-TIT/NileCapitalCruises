using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.AmenityDtos
{
    public class CabinRequestDto
    {
        public int? CruiseId { get; set; }
        public int? DeckId { get; set; }
        public int? CabinTypeId { get; set; }

        [MaxLength(150)]
        public string CabinNameSys { get; set; }
        [MaxLength(150)]
        public string CabinPhoto { get; set; }
        [MaxLength(150)]
        public string CabinBanner { get; set; }
        [MaxLength(150)]
        public string CabinUrl { get; set; }

        public int? NumberOfRooms { get; set; }
        public bool? CabinStatus { get; set; }
        public int? CabinPosition { get; set; }
        [MaxLength(150)]
        public string CabinSize { get; set; }
        public int? CabinPhotoWidth { get; set; }
        public int? CabinPhotoHeight { get; set; }
        public int? CabinBannerWidth { get; set; }
        public int? CabinBannerHeight { get; set; }
        [MaxLength(150)]
        public string CabinMinPax { get; set; }
        [MaxLength(150)]
        public string CabinMaxPax { get; set; }
        public bool? IsUpperDeckCabin { get; set; }

        public bool? Status { get; set; }

    }
}
