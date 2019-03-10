using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class VehicleMatch
    {
        [JsonProperty("vrm")]
        public string Vrm { get; private set;}

        [JsonProperty("type")]
        public string Type { get; private set;}

        [JsonProperty("make")]
        public string Make { get; private set;}

        [JsonProperty("model")]
        public string Model { get; private set;}

        [JsonProperty("colour")]
        public string Colour { get; private set;}

        [JsonProperty("compliance")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public VehicleMatchCompliance Compliance { get; private set;}


    }
}