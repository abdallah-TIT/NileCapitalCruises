using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.Helpers.Utils;
using NileCapitalCruises.Infrastructure.IServices.BookingEngine;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.ItineraryDtos;
using NileCapitalCruises.Infrastructure.Data.Specification.BookingEngine.ItinerarySpecification;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.PeriodSpecification;


namespace NileCapitalCruises.Infrastructure.Services.BookingEngine
{
    public class BEItineraryService : BEIItineraryService
    {
        private readonly IGenericRepo<Itinerary> _itineraryRepo;
        private readonly IGenericRepo<Period> _periodRepo;
        private readonly IGenericRepo<ItineraryContent> _itineraryContentRepo;
        private readonly IMapper _mapper;
        private readonly IHandleContents<ItineraryContent> _handleContent;

        public BEItineraryService(
            IGenericRepo<Itinerary> itineraryRepo,
            IGenericRepo<ItineraryContent> itineraryContentRepo,
            IMapper mapper,
            IHandleContents<ItineraryContent> handleContent,
            IGenericRepo<Period> periodRepo)
        {
            _itineraryRepo = itineraryRepo;
            _mapper = mapper;
            _handleContent = handleContent;
            _itineraryContentRepo = itineraryContentRepo;
            _periodRepo = periodRepo;
        }

        public async Task<IResponse> GetItineraries(int? itineraryTypeId, string operationDate, int maximumAdults, int maximumChildren, string languageCode = "en")
        {
            DateTime curentDate = DateTime.Parse(operationDate);

            var periodSpec = new CMSPeriodSpecification(curentDate);

            var period = await _periodRepo.GetEntityWithSpecAsync(periodSpec);

            if (period == null)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            }
            var priodId = period.Id;



            // Split the operationDate string based on the comma separator
            string[] dateParts = operationDate.Split(',');
            // Parse the individual parts into integers
            int operationYear = int.Parse(dateParts[0]);
            int operationMonth = int.Parse(dateParts[1]);
            int operationDay = int.Parse(dateParts[2]);

            var spec = new ItinerarySpecification(priodId,itineraryTypeId, maximumAdults, maximumChildren, operationDay,operationMonth,operationYear,languageCode);
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
