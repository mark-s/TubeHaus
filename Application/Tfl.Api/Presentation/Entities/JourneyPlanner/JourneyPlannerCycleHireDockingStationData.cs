using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
    public class JourneyPlannerCycleHireDockingStationData
    {
        [JsonProperty("originNumberOfBikes")]
        public int OriginNumberOfBikes { get; private set;}

        [JsonProperty("destinationNumberOfBikes")]
        public int DestinationNumberOfBikes { get; private set;}

        [JsonProperty("originNumberOfEmptySlots")]
        public int OriginNumberOfEmptySlots { get; private set;}

        [JsonProperty("destinationNumberOfEmptySlots")]
        public int DestinationNumberOfEmptySlots { get; private set;}

        [JsonProperty("originId")]
        public string OriginId { get; private set;}

        [JsonProperty("destinationId")]
        public string DestinationId { get; private set;}


    }
}