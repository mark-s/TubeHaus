using Newtonsoft.Json;

namespace Tfl.Api.Common
{
    public class GeoPoint
    {
        [JsonProperty("lat", Required = Required.Always)]
        public double Lat { get; private set;}

        [JsonProperty("lon", Required = Required.Always)]
        public double Lon { get; private set;}


    }
}