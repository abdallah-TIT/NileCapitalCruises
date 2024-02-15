using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.Helpers.Utils;
using NileCapitalCruises.Infrastructure.IServices.BookingEngine;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.ItineraryDtos;
using NileCapitalCruises.Infrastructure.Data.Specification.BookingEngine.ItinerarySpecification;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.CabinTypeCruiseDtos;


namespace NileCapitalCruises.Infrastructure.Services.BookingEngine
{
    public class BEItineraryService : BEIItineraryService
    {
        private readonly IGenericRepo<Itinerary> _itineraryRepo;
        private readonly IGenericRepo<ItineraryContent> _itineraryContentRepo;
        private readonly IMapper _mapper;
        private readonly IHandleContents<ItineraryContent> _handleContent;

        public BEItineraryService(
            IGenericRepo<Itinerary> itineraryRepo,
            IGenericRepo<ItineraryContent> itineraryContentRepo,
            IMapper mapper,
            IHandleContents<ItineraryContent> handleContent)
        {
            _itineraryRepo = itineraryRepo;
            _mapper = mapper;
            _handleContent = handleContent;
            _itineraryContentRepo = itineraryContentRepo;
        }

        public async Task<IResponse> GetItineraries(int? itineraryTypeId, int? maximumAdults, int? maximumChildren, int? operationDay, int? operationMonth, int? operationYear,string languageCode = "en")
        {
            var spec = new ItinerarySpecification(itineraryTypeId, maximumAdults, maximumChildren, operationDay,operationMonth,operationYear,languageCode);
            var items = await _itineraryRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


            var data = _mapper.Map<IReadOnlyList<ItineraryWithContentResponseDto>>(items);

            return SuccessListResponse<ItineraryWithContentResponseDto>.Success(
                    data != null,
                    StatusCodeAndErrorsMessagesStandard.OK,
                    data
                   
                );
        }



    }
}
