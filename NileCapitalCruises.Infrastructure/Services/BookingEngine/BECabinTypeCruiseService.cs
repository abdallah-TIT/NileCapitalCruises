using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data.Specification.BookingEngine.CabinTypeCruiseSpecification;
using NileCapitalCruises.Infrastructure.Data.Specification.BookingEngine.ItinerarySpecification;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.CabinTypeCruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.ItineraryDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.Helpers.Utils;
using NileCapitalCruises.Infrastructure.IServices.BookingEngine;


namespace NileCapitalCruises.Infrastructure.Services.BookingEngine
{
    public class BECabinTypeCruiseService : BEICabinTypeCruiseService
    {
        private readonly IGenericRepo<CabinTypeCruise> _cabinTypeCruiseRepo;
        private readonly IMapper _mapper;

        public BECabinTypeCruiseService(
            IMapper mapper
,
            IGenericRepo<CabinTypeCruise> cabinTypeCruiseRepo)
        {
            _mapper = mapper;
            _cabinTypeCruiseRepo = cabinTypeCruiseRepo;
        }


        public async Task<IResponse> GetCabinTypeCruises(string operationDate, int maximumAdults,int maximumChildren,string languageCode = "en")
        {
            //DateTime dateTime = DateTime.Parse(operationDate);

            //int operationYear = dateTime.Year;
            //int operationMonth = dateTime.Month;
            //int operationDay = dateTime.Day;

            // Split the operationDate string based on the comma separator
            string[] dateParts = operationDate.Split(',');
            // Parse the individual parts into integers
            int operationYear = int.Parse(dateParts[0]);
            int operationMonth = int.Parse(dateParts[1]);
            int operationDay = int.Parse(dateParts[2]);

            var cruiseId = 6;
           

            var spec = new CabinTypeCruiseSpecification(cruiseId, maximumAdults, maximumChildren, operationDay, operationMonth, operationYear, languageCode);
            var items = await _cabinTypeCruiseRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


            var data = _mapper.Map<IReadOnlyList<CabinTypeCruiseWithContentResponseDto>>(items);

            return SuccessListResponse<CabinTypeCruiseWithContentResponseDto>.Success(
                    data != null,
                    StatusCodeAndErrorsMessagesStandard.OK,
                    data

                );
        }


    }
}
