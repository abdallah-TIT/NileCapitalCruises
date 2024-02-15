﻿using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.OperationDateDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;

namespace NileCapitalCruises.Infrastructure.IServices.CMS
{
    public interface IOperationDateService
    {
        Task<IResponse> CreateOperationDate(int companyId, OperationDateRequestDto requestDto);
       
    }
}
