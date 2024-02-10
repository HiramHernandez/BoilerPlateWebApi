namespace BoilerPlateWebApi.Utilities
{
    public class ApiResponse<T>
    {
        public bool status { get; set; }
        public T data { get; set; }
        public string msg { get; set; }
    }

    public class ApiResponsePagination<T> : ApiResponse<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
    }

}
