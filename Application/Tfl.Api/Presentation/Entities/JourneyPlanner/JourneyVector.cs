using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
    public class JourneyVector
    {
        [JsonProperty("from")]
        public string From { get; private set;}

        [JsonProperty("to")]
        public string To { get; private set;}

        [JsonProperty("via")]
        public string Via { get; private set;}

        [JsonProperty("uri")]
        public string Uri { get; private set;}


    }
}