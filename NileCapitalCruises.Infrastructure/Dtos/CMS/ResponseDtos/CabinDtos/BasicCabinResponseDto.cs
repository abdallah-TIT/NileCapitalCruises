﻿
namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CabinDtos
{
    public class BasicCabinResponseDto
    {
        public int? CruiseId { get; set; }
        public int? DeckId { get; set; }
        public int? CabinTypeId { get; set; }
        public int? NumberOfRooms { get; set; }
        public string? CabinNameSys { get; set; }
        public string? CabinPhoto { get; set; }
        public string? CabinBanner { get; set; }
        public string? CabinUrl { get; set; }
        public bool? CabinStatus { get; set; }
        public int? CabinPosition { get; set; }
        public string? CabinSize { get; set; }
        public int? CabinPhotoWidth { get; set; }
        public int? CabinPhotoHeight { get; set; }
        public int? CabinBannerWidth { get; set; }
        public int? CabinBannerHeight { get; set; }
        public string? CabinMinPax { get; set; }
        public string? CabinMaxPax { get; set; }
        public bool? IsUpperDeckCabin { get; set; }
        public bool? Status { get; set; }


    }
}
