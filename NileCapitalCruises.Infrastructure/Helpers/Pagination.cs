namespace NileCapitalCruises.Infrastructure.Helpers
{
    public class Pagination<T> where T : class
    {

       

        public Pagination(IReadOnlyList<T> data, int pageIndex = 1, int pageSize = 6, int count = 1)
        {
            
            PageIndex = pageIndex;
            PageSize = pageSize;
            Count = count;
            Data = data;
        }

        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int Count { get; set; }
        public IReadOnlyList<T> Data { get; set; }
    }
}
