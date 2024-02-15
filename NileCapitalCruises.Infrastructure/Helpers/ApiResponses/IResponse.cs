
namespace NileCapitalCruises.Infrastructure.Helpers.ApiResponses
{
    public interface IResponse
    {
        public bool Status { get; set; }
        public int StatusCode { get; set; }
    }
}
