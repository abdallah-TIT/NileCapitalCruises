namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CabinTypeCruiseDtos
{
    public class CMSCabinTypeCruiseWithContentResponseDto
    {
        public int? CabinTypeCruiseId { get; set; }
        public int? CruiseId { get; set; }

        public int? NumberOfRooms { get; set; }
        public int? MaximumAdults { get; set; }
        public int? MaximumChildren { get; set; }
        
        public int? Occupancy { get; set; }


        public string? CabinTypeNameSys { get; set; }

        public string? CabinTypeName { get; set; }


    }
}
