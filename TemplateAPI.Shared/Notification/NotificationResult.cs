using System.Net;

namespace TemplateAPI.Shared.Notification
{
    public class NotificationResult<T>
    {
        public bool Success { get; }
        public T? Data { get; }
        public string ErrorMessage { get; }
        public HttpStatusCode StatusCode { get; }
        public PagerSettings PagerSettings { get; set; }

        private NotificationResult(bool success, T data, string errorMessage, HttpStatusCode httpStatus)
        {
            Success = success;
            Data = data;
            ErrorMessage = errorMessage;
            StatusCode = httpStatus;
            PagerSettings = new PagerSettings();
        }

        public static NotificationResult<T> SuccessResult(T data, HttpStatusCode statusCode = HttpStatusCode.OK, string? errorMessage = null)
        {
            return new NotificationResult<T>(true, data, errorMessage, statusCode);
        }

        public static NotificationResult<T> ErrorResult(string errorMessage, HttpStatusCode statusCode)
        {
            return new NotificationResult<T>(false, default, errorMessage, statusCode);
        }

    }
}
