using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
    public class TimeAdjustments
    {
        [JsonProperty("earliest")]
        public TimeAdjustment Earliest { get; private set;}

        [JsonProperty("earlier")]
        public TimeAdjustment Earlier { get; private set;}

        [JsonProperty("later")]
        public TimeAdjustment Later { get; private set;}

        [JsonProperty("latest")]
        public TimeAdjustment Latest { get; private set;}


    }
}