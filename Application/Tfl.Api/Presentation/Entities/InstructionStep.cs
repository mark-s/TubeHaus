using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class InstructionStep
    {
        [JsonProperty("description")]
        public string Description { get; private set;}

        [JsonProperty("turnDirection")]
        public string TurnDirection { get; private set;}

        [JsonProperty("streetName")]
        public string StreetName { get; private set;}

        [JsonProperty("distance")]
        public int Distance { get; private set;}

        [JsonProperty("cumulativeDistance")]
        public int CumulativeDistance { get; private set;}

        [JsonProperty("skyDirection")]
        public int SkyDirection { get; private set;}

        [JsonProperty("skyDirectionDescription")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public InstructionStepSkyDirectionDescription SkyDirectionDescription { get; private set;}

        [JsonProperty("cumulativeTravelTime")]
        public int CumulativeTravelTime { get; private set;}

        [JsonProperty("latitude")]
        public double Latitude { get; private set;}

        [JsonProperty("longitude")]
        public double Longitude { get; private set;}

        [JsonProperty("pathAttribute")]
        public PathAttribute PathAttribute { get; private set;}

        [JsonProperty("descriptionHeading")]
        public string DescriptionHeading { get; private set;}

        [JsonProperty("trackType")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public InstructionStepTrackType TrackType { get; private set;}


    }
}