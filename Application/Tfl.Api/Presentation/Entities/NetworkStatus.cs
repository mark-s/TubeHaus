using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    /// <summary>Represent travel network status</summary>
    public class NetworkStatus
    {
        [JsonProperty("operator")]
        public string Operator { get;  }

        [JsonProperty("status")]
        public string Status { get;  }

        [JsonProperty("message")]
        public string Message { get; }

        [JsonProperty("statusLevel")]
        public int StatusLevel { get;  }

        public NetworkStatus(string @operator, string status, string message, int statusLevel)
        {
            Operator = @operator;
            Status = status;
            Message = message;
            StatusLevel = statusLevel;
        }
    }
}