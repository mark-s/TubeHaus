using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class ActiveServiceType
    {
        [JsonProperty("mode")]
        public string Mode { get; private set;}

        [JsonProperty("serviceType")]
        public string ServiceType { get; private set;}


    }
}