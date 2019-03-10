using System.Threading.Tasks;
using Refit;

namespace TubeHaus.External.Tfl.Api
{
    public abstract class ServiceBase
    {
        protected static async Task<ApiResult<T>> TryCall<T>(Task<T> callFunc)
        {
            try
            {
                var result = await callFunc;
                return ApiResult<T>.Ok(result);
            }
            catch (ApiException exception)
            {
                return ApiResult<T>.Error(exception);
            }
        }
    }
}