using System;

namespace TubeHaus.External.Tfl.Api
{
    public class ApiResult<T>
    {
        public bool IsSuccess { get; }
        public Exception Exception { get; }
        public T Response { get; }

        private ApiResult(bool isSuccess, Exception exception, T response)
        {
            IsSuccess = isSuccess;
            Exception = exception;
            Response = response;
        }

        public static ApiResult<T> Ok(T response)
            => new ApiResult<T>(true, null, response);

        public static ApiResult<T> Error(Exception exception)
            => new ApiResult<T>(false, exception, default(T));
    }
}