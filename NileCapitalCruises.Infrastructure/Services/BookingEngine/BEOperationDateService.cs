using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.Helpers.Utils;
using NileCapitalCruises.Infrastructure.IServices.BookingEngine;
using NileCapitalCruises.Infrastructure.Data.Specification.BookingEngine.ItineraryTypeSpecification;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.ItineraryTypeDtos;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using NileCapitalCruises.Infrastructure.Data.Specification.BookingEngine.OperationDateSpecification;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.DiningTypeDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.OperationDateDtos;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.OperationDateDtos;


namespace NileCapitalCruises.Infrastructure.Services.BookingEngine
{
    public class BEOperationDateService : BEIOperationDateService
    {
        private readonly IGenericRepo<OperationDate> _operationDateRepo;
        private readonly IMapper _mapper;

        public BEOperationDateService(
            IGenericRepo<OperationDate> operationDateRepo,
            IMapper mapper
            )
        {
            _operationDateRepo = operationDateRepo;
            _mapper = mapper;
            
        }

        public async Task<IResponse> GetOperationDates(int itineraryTypeId)
        {
            var spec = new OperationDateSpecification(itineraryTypeId);
            var items = await _operationDateRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


            var data = _mapper.Map<IReadOnlyList<BEBasicOperationDateResponseDto>>(items);

            return SuccessListResponse<BEBasicOperationDateResponseDto>.Success(
                    data != null,
                    StatusCodeAndErrorsMessagesStandard.OK,
                    data
                   
                );
        }



    }
}
