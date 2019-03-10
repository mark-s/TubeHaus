using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class LineSpecificServiceType
    {
        [JsonProperty("serviceType")]
        public LineServiceTypeInfo ServiceType { get; private set;}

        [JsonProperty("stopServesServiceType")]
        public bool StopServesServiceType { get; private set;}


    }
}