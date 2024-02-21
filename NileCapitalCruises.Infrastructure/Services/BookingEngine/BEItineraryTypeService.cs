using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.Helpers.Utils;
using NileCapitalCruises.Infrastructure.IServices.BookingEngine;
using NileCapitalCruises.Infrastructure.Data.Specification.BookingEngine.ItineraryTypeSpecification;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.ItineraryTypeDtos;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.OperationDateDtos;
using NileCapitalCruises.Infrastructure.Data.Specification.BookingEngine.OperationDateSpecification;


namespace NileCapitalCruises.Infrastructure.Services.BookingEngine
{
    public class BEItineraryTypeService : BEIItineraryTypeService
    {
        private readonly IGenericRepo<ItineraryType> _itineraryTypeRepo;
        private readonly IGenericRepo<OperationDate> _operationDateRepo;
        private readonly IGenericRepo<ItineraryTypeContent> _itineraryTypeContentRepo;
        private readonly IMapper _mapper;
        private readonly IHandleContents<ItineraryTypeContent> _handleContent;

        public BEItineraryTypeService(
            IGenericRepo<ItineraryType> itineraryTypeRepo,
            IGenericRepo<OperationDate> operationDateRepo,
            IGenericRepo<ItineraryTypeContent> itineraryTypeContentRepo,
            IMapper mapper,
            IHandleContents<ItineraryTypeContent> handleContent)
        {
            _itineraryTypeRepo = itineraryTypeRepo;
            _mapper = mapper;
            _handleContent = handleContent;
            _itineraryTypeContentRepo = itineraryTypeContentRepo;
            _operationDateRepo = operationDateRepo;
        }

        public async Task<IResponse> GetItineraryTypes(string languageCode = "en")
        {
            var spec = new ItineraryTypeSpecification(languageCode);
            var items = await _itineraryTypeRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

            var specOp = new OperationDateSpecification();
            var opItems = await _operationDateRepo.ListAsync(specOp);
            var opItemsDTO = _mapper.Map<IReadOnlyList<BEBasicOperationDateResponseDto>>(opItems);

            //var itineraryTypeIdsWithOperationDates = opItems
            //                                .Select(op => op.Itinerary.ItineraryTypeId)
            //                                .Distinct();


            var data = items./*Where(it => itineraryTypeIdsWithOperationDates.Contains(it.Id)).*/
                Select(i => new ItineraryTypeWithContentResponseDto() 
            {
                ItineraryTypeId = i.Id,
                ItineraryTypeNameSys = i.ItineraryTypeNameSys,
                ItineraryTypeName = i.ItineraryTypeContents.FirstOrDefault().ItineraryTypeName,
                dates = opItemsDTO.Where(op => op.Itinerary.ItineraryTypeId == i.Id).ToList()

            } ).ToList();
            //var data = _mapper.Map<IReadOnlyList<ItineraryTypeWithContentResponseDto>>(items);

            //data.Select(x => x.dates = opItemsDTO.Where(op => op.Itinerary.ItineraryTypeId == x.ItineraryTypeId));

            //foreach (var item in data)
            //{
            //    item.dates = opItemsDTO.Where(op => op.Itinerary.ItineraryTypeId == item.ItineraryTypeId).ToList();
            //}

            return SuccessListResponse<ItineraryTypeWithContentResponseDto>.Success(
                    data != null,
                    StatusCodeAndErrorsMessagesStandard.OK,
                    data
                   
                );
        }



    }
}
