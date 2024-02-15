
namespace NileCapitalCruises.Infrastructure.Helpers.ApiResponses
{
    public class SuccessPaginationResponse<T> : IResponse
    {

        public SuccessPaginationResponse(bool status, int statusCode, IReadOnlyList<T> data, int pageIndex, int pageSize, int count)
        
        {
            Status = status;
            StatusCode = statusCode;
            PageIndex = pageIndex;
            PageSize = pageSize;
            Count = count;
            Data = data;
        }

        public bool Status { get; set; }

        public int StatusCode { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int Count { get; set; }
        public IReadOnlyList<T> Data { get; set; }

        public static SuccessPaginationResponse<T> Success(bool status,int statusCode, IReadOnlyList<T> data, int pageIndex, int pageSize, int count)
        {
            return new SuccessPaginationResponse<T>(status, statusCode, data, pageIndex, pageSize, count);
        }

    }
}
