using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class MatchedStop
    {
        [JsonProperty("routeId")]
        public int RouteId { get; private set;}

        [JsonProperty("parentId")]
        public string ParentId { get; private set;}

        [JsonProperty("stationId")]
        public string StationId { get; private set;}

        [JsonProperty("icsId")]
        public string IcsId { get; private set;}

        [JsonProperty("topMostParentId")]
        public string TopMostParentId { get; private set;}

        [JsonProperty("direction")]
        public string Direction { get; private set;}

        [JsonProperty("towards")]
        public string Towards { get; private set;}

        [JsonProperty("modes")]
        public ICollection<string> Modes { get; private set;}

        [JsonProperty("stopType")]
        public string StopType { get; private set;}

        [JsonProperty("stopLetter")]
        public string StopLetter { get; private set;}

        [JsonProperty("zone")]
        public string Zone { get; private set;}

        [JsonProperty("accessibilitySummary")]
        public string AccessibilitySummary { get; private set;}

        [JsonProperty("hasDisruption")]
        public bool HasDisruption { get; private set;}

        [JsonProperty("lines")]
        public ICollection<Identifier> Lines { get; private set;}

        [JsonProperty("status")]
        public bool Status { get; private set;}

        [JsonProperty("id")]
        public string Id { get; private set;}

        [JsonProperty("url")]
        public string Url { get; private set;}

        [JsonProperty("name")]
        public string Name { get; private set;}

        [JsonProperty("lat")]
        public double Lat { get; private set;}

        [JsonProperty("lon")]
        public double Lon { get; private set;}


    }
}