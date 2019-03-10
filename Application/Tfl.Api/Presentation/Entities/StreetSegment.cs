using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class StreetSegment
    {
        /// <summary>A 16 digit unique integer identifying a OS ITN (Ordnance Survey Integrated Transport Network) road link.</summary>
        [JsonProperty("toid")]
        public string Toid { get; private set;}

        /// <summary>geoJSON formatted LineString containing two latitude/longitude (WGS84) pairs that identify the start and end points of the street segment.</summary>
        [JsonProperty("lineString")]
        public string LineString { get; private set;}

        /// <summary>The ID from the source system of the disruption that this street belongs to.</summary>
        [JsonProperty("sourceSystemId")]
        public long SourceSystemId { get; private set;}

        /// <summary>The key of the source system of the disruption that this street belongs to.</summary>
        [JsonProperty("sourceSystemKey")]
        public string SourceSystemKey { get; private set;}


    }
}