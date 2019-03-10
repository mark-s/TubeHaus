using Newtonsoft.Json;

namespace Tfl.Api.RequestModels
{
    public class DbGeographyWellKnownValue
    {
        [JsonProperty("coordinateSystemId")]
        public int CoordinateSystemId { get; set;}

        [JsonProperty("wellKnownText")]
        public string WellKnownText { get; set;}

        [JsonProperty("wellKnownBinary")]
        public byte[] WellKnownBinary { get; set;}


    }
}