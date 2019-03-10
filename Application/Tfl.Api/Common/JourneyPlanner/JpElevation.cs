using Newtonsoft.Json;

namespace Tfl.Api.Common.JourneyPlanner
{
    public class JpElevation
    {
        [JsonProperty("distance")]
        public int Distance { get; private set;}

        [JsonProperty("startLat")]
        public double StartLat { get; private set;}

        [JsonProperty("startLon")]
        public double StartLon { get; private set;}

        [JsonProperty("endLat")]
        public double EndLat { get; private set;}

        [JsonProperty("endLon")]
        public double EndLon { get; private set;}

        [JsonProperty("heightFromPreviousPoint")]
        public int HeightFromPreviousPoint { get; private set;}

        [JsonProperty("gradient")]
        public double Gradient { get; private set;}


    }
}