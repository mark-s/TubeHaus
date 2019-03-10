using Newtonsoft.Json;

namespace Tfl.Api.Common
{
    public class GeoPointBBox
    {
        [JsonProperty("swLat", Required = Required.Always)]
        public double SwLat { get; private set;}

        [JsonProperty("swLon", Required = Required.Always)]
        public double SwLon { get; private set;}

        [JsonProperty("neLat", Required = Required.Always)]
        public double NeLat { get; private set;}

        [JsonProperty("neLon", Required = Required.Always)]
        public double NeLon { get; private set;}


    }
}