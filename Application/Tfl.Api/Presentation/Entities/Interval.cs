using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class Interval
    {
        [JsonProperty("stopId")]
        public string StopId { get; private set;}

        [JsonProperty("timeToArrival")]
        public double TimeToArrival { get; private set;}


    }
}