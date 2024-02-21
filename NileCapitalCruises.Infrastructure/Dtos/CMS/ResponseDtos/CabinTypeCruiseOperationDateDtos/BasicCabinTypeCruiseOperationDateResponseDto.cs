using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CabinTypeCruiseOperationDateDtos
{
    public class BasicCabinTypeCruiseOperationDateResponseDto
    {
        public int OperationDateId { get; set; }
        public int CabinTypeCruiseId { get; set; }
        public int? Allotment { get; set; }

        public string? CabinTypeNameSys { get; set; }
        public string? CabinTypeName { get; set; }
    }
}
