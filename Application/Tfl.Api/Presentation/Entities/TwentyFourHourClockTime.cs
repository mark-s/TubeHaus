using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class TwentyFourHourClockTime
    {
        [JsonProperty("hour")]
        public string Hour { get; private set;}

        [JsonProperty("minute")]
        public string Minute { get; private set;}


    }
}