namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos
{
    public class CMSCruisePhotoResponseDto
    {
        public int Id { get; set; }

        public int? CruiseId { get; set; }
        public string PhotoFile { get; set; }
        public int PhotoPosition { get; set; }
        public bool PhotoStatus { get; set; }
        public int PhotoHieght { get; set; }
        public int PhotoWidth { get; set; }
    }
}
