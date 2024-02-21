
using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.OperationDateDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.OperationDateDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.Http;
using System.Transactions;
using System.Globalization;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.OperationDateSpecification;

namespace NileCapitalCruises.Infrastructure.Services.CMS
{
    public class OperationDateService : IOperationDateService
    {
        private readonly IGenericRepo<OperationDate> _operationDateRepo;
        private readonly IGenericRepo<CabinTypeCruiseOperationDate> _cabinTypeCruiseOperationDateRepo;
        private readonly HttpContext _httpContext;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;

        public OperationDateService(
            IGenericRepo<OperationDate> operationDateRepo,
            IHttpContextAccessor httpContextAccessor,
            ITokenService tokenService,
            IMapper mapper,
            IGenericRepo<CabinTypeCruiseOperationDate> cabinTypeCruiseOperationDateRepo)
        {
            _operationDateRepo = operationDateRepo;
            _httpContext = httpContextAccessor.HttpContext;
            _tokenService = tokenService;
            _mapper = mapper;
            _cabinTypeCruiseOperationDateRepo = cabinTypeCruiseOperationDateRepo;
        }
        public async Task<IResponse> CreateOperationDate(int companyId, OperationDateRequestDto requestDto)
        {

            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {

                    var claims = _tokenService.GetClaimsFromJwt(_httpContext);
                    if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
                    {
                        return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                    }

                    var request = _mapper.Map<OperationDate>(requestDto);
                    request.CompanyId = companyId;
                    var newItem = await _operationDateRepo.CreateEntityAsync(request);
                    if (newItem == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                    

                    await _operationDateRepo.SaveChangesAsync();

                   
                    var companyDto = _mapper.Map<BasicOperationDateResponseDto>(newItem);
                    scope.Complete();
                    return SuccessSingleResponse<BasicOperationDateResponseDto>.Success(companyDto, StatusCodeAndErrorsMessagesStandard.Created);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.InternalServerError);
                }
            }
        }

        //public async Task<IResponse> CreateOperationDates(int companyId, OperationDatesRequestDto requestDto)
        //{
        //    using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
        //    {
        //        try
        //        {
        //            var claims = _tokenService.GetClaimsFromJwt(_httpContext);
        //            if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
        //            {
        //                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);
        //            }

        //            // Parse start date and end date
        //            DateTime startDate = DateTime.ParseExact(requestDto.StartDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
        //            DateTime endDate = DateTime.ParseExact(requestDto.EndDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);

        //            // Validate start date is before end date
        //            if (startDate >= endDate)
        //            {
        //                return FailResponse.Error(new List<string> { "Start date must be before end date" }, StatusCodeAndErrorsMessagesStandard.BadRequest);
        //            }

        //            var newItems = new List<OperationDate>();

        //            // Iterate through the range of dates
        //            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
        //            {
        //                var day = ((int)date.DayOfWeek + 1);
        //            // Check if the weekday matches Sunday
        //            if (((int)date.DayOfWeek + 1) == requestDto.WeekDayId)
        //                {
        //                    var request = new OperationDate
        //                    {
        //                        CruiseId = requestDto.CruiseId,
        //                        WeekDayId = requestDto.WeekDayId,
        //                        ItineraryId = requestDto.ItineraryId,
        //                        Operation_Date = date,
        //                        EmbarcationCityId = requestDto.EmbarcationCityId,
        //                        CompanyId = companyId
        //                    };

        //                    newItems.Add(request);
        //                }
        //            }

        //            // Create and save entities
        //            var createdItems = await _operationDateRepo.CreateEntitiesAsync(newItems);

        //            await _operationDateRepo.SaveChangesAsync();

        //            // Map to DTOs
        //            var operationDateDto = _mapper.Map<IEnumerable<BasicOperationDateResponseDto>>(createdItems);

        //            scope.Complete();

        //            return SuccessSingleResponse<IEnumerable<BasicOperationDateResponseDto>>.Success(operationDateDto, StatusCodeAndErrorsMessagesStandard.Created);
        //        }
        //        catch (Exception)
        //        {
        //            return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.InternalServerError);
        //        }
        //    }
        //}

        public async Task<IResponse> CreateOperationDates(int companyId, OperationDatesRequestDto requestDto)
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var claims = _tokenService.GetClaimsFromJwt(_httpContext);
                    if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
                    {
                        return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);
                    }

                    // Parse start date and end date
                    DateTime startDate = DateTime.ParseExact(requestDto.StartDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    DateTime endDate = DateTime.ParseExact(requestDto.EndDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                    // Validate start date is before end date
                    if (startDate >= endDate)
                    {
                        return FailResponse.Error(new List<string> { "Start date must be before end date" }, StatusCodeAndErrorsMessagesStandard.BadRequest);
                    }

                    var newOperationDates = new List<OperationDate>();
                    var newCabinTypeCruiseOperationDates = new List<CabinTypeCruiseOperationDate>();

                    // Iterate through the range of dates
                    for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                    {
                        // Check if the weekday matches the specified weekday
                        if (((int)date.DayOfWeek + 1) == requestDto.WeekDayId)
                        {
                            var operationDate = new OperationDate
                            {
                                CruiseId = requestDto.CruiseId,
                                WeekDayId = requestDto.WeekDayId,
                                ItineraryId = requestDto.ItineraryId,
                                Operation_Date = date,
                                EmbarcationCityId = requestDto.EmbarcationCityId,
                                CompanyId = companyId
                            };

                            newOperationDates.Add(operationDate);

                            // Create CabinTypeCruiseOperationDate entities for each cabin allotment
                            newCabinTypeCruiseOperationDates.AddRange(requestDto.CabinAllotments.Select(cabinAllotment =>
                                new CabinTypeCruiseOperationDate
                                {
                                    OperationDate = operationDate,
                                    CabinTypeCruiseId = cabinAllotment.Key,
                                    Allotment = cabinAllotment.Value,
                                    
                                }));
                        }
                    }

                    // Create and save OperationDate entities
                    await _operationDateRepo.CreateEntitiesAsync(newOperationDates);

                    // Create and save CabinTypeCruiseOperationDate entities
                    await _cabinTypeCruiseOperationDateRepo.CreateEntitiesAsync(newCabinTypeCruiseOperationDates);

                    // Save changes
                    await _operationDateRepo.SaveChangesAsync();

                    // Map to DTOs if needed
                    var operationDateDto = _mapper.Map<IEnumerable<BasicOperationDateResponseDto>>(newOperationDates);

                    scope.Complete();

                    return SuccessSingleResponse<IEnumerable<BasicOperationDateResponseDto>>.Success(operationDateDto, StatusCodeAndErrorsMessagesStandard.Created);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.InternalServerError);
                }
            }
        }

        public async Task<IResponse> GetOperationDates(int itineraryId, PaginationSpecParams paginationSpecParams)
        {

            var spec = new CMSOperationDateSpecification(paginationSpecParams, itineraryId);
            var countSpec = new CMSOperationDateWithFiltersForCountSpecification(paginationSpecParams, itineraryId);
            var totalItems = await _operationDateRepo.CountAsync(countSpec);
            var items = await _operationDateRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


            var data = _mapper.Map<IReadOnlyList<BasicOperationDateResponseDto>>(items);

            return SuccessPaginationResponse<BasicOperationDateResponseDto>.Success(
                    data != null,
                    StatusCodeAndErrorsMessagesStandard.OK,
                    data,
                    paginationSpecParams.PageIndex,
                    paginationSpecParams.PageSize,
                    totalItems
                );
        }
    }
}
