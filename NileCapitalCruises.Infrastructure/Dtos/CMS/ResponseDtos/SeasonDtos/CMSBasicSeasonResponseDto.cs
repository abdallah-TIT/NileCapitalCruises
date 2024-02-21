


namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.SeasonDtos
{
    public class CMSBasicSeasonResponseDto
    {
        public int SeasonId { get; set; }

        public int? CruiseId { get; set; }
       
        public string? SeasonNameSys { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }



        
    }
}
