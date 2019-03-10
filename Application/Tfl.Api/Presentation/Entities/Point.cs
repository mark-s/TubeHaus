using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    /// <summary>Represents a point located at a latitude and longitude using the WGS84 co-ordinate system.</summary>
    
    public class Point
    {
        /// <summary>WGS84 latitude of the location.</summary>
        [JsonProperty("lat")]
        public double Lat { get; private set;}

        /// <summary>WGS84 longitude of the location.</summary>
        [JsonProperty("lon")]
        public double Lon { get; private set;}


    }
}