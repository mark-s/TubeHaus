using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
    public class Obstacle
    {
        [JsonProperty("type")]
        public string Type { get; private set;}

        [JsonProperty("incline")]
        public string Incline { get; private set;}

        [JsonProperty("stopId")]
        public int StopId { get; private set;}

        [JsonProperty("position")]
        public string Position { get; private set;}


    }
}