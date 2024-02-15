namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CabinDtos
{
    public class CabinPhotoResponseDto
    {
        public int Id { get; set; }

        public int? CabinId { get; set; }

        public string PhotoFile { get; set; }
        public int? PhotoPosition { get; set; }
        public bool? PhotoStatus { get; set; }
        public int? PhotoHieght { get; set; }
        public int? PhotoWidth { get; set; }
    }
}
