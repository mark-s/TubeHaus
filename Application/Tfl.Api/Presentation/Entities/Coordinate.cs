using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class Coordinate
    {
        [JsonProperty("longitude")]
        public double Longitude { get; private set;}

        [JsonProperty("latitude")]
        public double Latitude { get; private set;}

        [JsonProperty("easting")]
        public double Easting { get; private set;}

        [JsonProperty("northing")]
        public double Northing { get; private set;}

        [JsonProperty("xCoord")]
        public int XCoord { get; private set;}

        [JsonProperty("yCoord")]
        public int YCoord { get; private set;}


    }
}