using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.OperationDateDtos;

namespace NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.ItineraryTypeDtos
{
    public class ItineraryTypeWithContentResponseDto
    {
        public int ItineraryTypeId { get; set; }
        public string? ItineraryTypeNameSys { get; set; }



        ////
        ///

        public string? ItineraryTypeName { get; set; }


        public IEnumerable<BEBasicOperationDateResponseDto> dates { get; set; }

    }
}
