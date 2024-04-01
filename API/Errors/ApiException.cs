namespace API.Errors
{
    public class ApiException
    {
        public ApiException(int StatusCode, string message = null, string details = null)
        {
            this.StatusCode = StatusCode;
            this.Message = message;
            this.Details = details;
        }


        public int StatusCode { get; set; }

        public string Message { get; set; }

        public string Details { get; set; }

    }
}
