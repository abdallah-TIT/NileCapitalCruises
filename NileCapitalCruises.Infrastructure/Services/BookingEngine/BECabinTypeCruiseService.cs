using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data.Specification.BookingEngine.CabinTypeCruiseSpecification;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.CompanySpecification;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.CabinTypeCruiseDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices.BookingEngine;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.PeriodSpecification;


namespace NileCapitalCruises.Infrastructure.Services.BookingEngine
{
    public class BECabinTypeCruiseService : BEICabinTypeCruiseService
    {
        private readonly IGenericRepo<CabinTypeCruise> _cabinTypeCruiseRepo;
        private readonly IGenericRepo<Period> _periodRepo;
        private readonly IMapper _mapper;

        public BECabinTypeCruiseService(
            IMapper mapper
,
            IGenericRepo<CabinTypeCruise> cabinTypeCruiseRepo,
            IGenericRepo<Period> periodRepo)
        {
            _mapper = mapper;
            _cabinTypeCruiseRepo = cabinTypeCruiseRepo;
            _periodRepo = periodRepo;
        }


        public async Task<IResponse> GetCabinTypeCruises(int itineraryTypeId, int cruiseId,string operationDate, int maximumAdults,int maximumChildren,string languageCode = "en")
        {
            DateTime curentDate = DateTime.Parse(operationDate);

            var periodSpec = new CMSPeriodSpecification(curentDate);

            var period = await _periodRepo.GetEntityWithSpecAsync(periodSpec);

            if(period == null)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            }
            var priodId = period.Id;

            //int operationYear = dateTime.Year;
            //int operationMonth = dateTime.Month;
            //int operationDay = dateTime.Day;

            // Split the operationDate string based on the comma separator
            string[] dateParts = operationDate.Split(',');
            // Parse the individual parts into integers
            int operationYear = int.Parse(dateParts[0]);
            int operationMonth = int.Parse(dateParts[1]);
            int operationDay = int.Parse(dateParts[2]);

            
           

            var spec = new CabinTypeCruiseSpecification(itineraryTypeId, priodId , cruiseId, maximumAdults, maximumChildren, operationDay, operationMonth, operationYear, languageCode);
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
