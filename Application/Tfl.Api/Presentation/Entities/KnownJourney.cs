using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class KnownJourney
    {
        [JsonProperty("hour")]
        public string Hour { get; private set;}

        [JsonProperty("minute")]
        public string Minute { get; private set;}

        [JsonProperty("intervalId")]
        public int IntervalId { get; private set;}


    }
}