using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
    public class TimeAdjustment
    {
        [JsonProperty("date")]
        public string Date { get; private set;}

        [JsonProperty("time")]
        public string Time { get; private set;}

        [JsonProperty("timeIs")]
        public string TimeIs { get; private set;}

        [JsonProperty("uri")]
        public string Uri { get; private set;}


    }
}