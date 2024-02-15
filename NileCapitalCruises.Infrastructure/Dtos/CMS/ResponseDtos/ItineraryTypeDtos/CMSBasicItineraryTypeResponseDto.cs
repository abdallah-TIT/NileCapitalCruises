namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.ItineraryTypeDtos
{
    public class CMSBasicItineraryTypeResponseDto
    {
        public int ItineraryTypeId { get; set; }
        public string? ItineraryTypeNameSys { get; set; }
        public int? ItineraryDays { get; set; }
        public int? ItineraryNights { get; set; }

        public int? SailFrom { get; set; }

        public int? SailTo { get; set; }

    }
}
