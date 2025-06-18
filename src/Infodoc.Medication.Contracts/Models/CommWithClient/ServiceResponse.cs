
namespace Infodoc.Medication.Contracts.Models.CommWithClient
{
    public class ServiceResponse<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public string ErrorMessage { get; set; }
        public int StatusCode { get; set; }

        public ServiceResponse() { }

        public ServiceResponse(T data, bool success = true, string errorMessage = null, int statusCode = 200)
        {
            Success = success;
            Data = data;
            ErrorMessage = errorMessage;
            StatusCode = statusCode;
        }

        public static ServiceResponse<T> CreateSuccessResponse(T data, int statusCode = 200)
        {
            return new ServiceResponse<T>(data, true, null, statusCode);
        }

        public static ServiceResponse<T> CreateErrorResponse(string errorMessage, int statusCode)
        {
            return new ServiceResponse<T>(default, false, errorMessage, statusCode);
        }
    }
}
