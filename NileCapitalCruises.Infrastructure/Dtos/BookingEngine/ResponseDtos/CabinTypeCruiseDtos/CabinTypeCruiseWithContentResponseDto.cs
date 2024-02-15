namespace NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.CabinTypeCruiseDtos
{
    public class CabinTypeCruiseWithContentResponseDto
    {
        public int? CabinTypeCruiseId { get; set; }
         
        public string? CabinTypeNameSys { get; set; }

        public string? CabinTypeName { get; set; }

        public int? Allotment { get; set; }
        public virtual IReadOnlyList<BECabinTypeCruisePhotoResponseDto> CabinTypeCruisePhotos { get; set; }





    }
}
