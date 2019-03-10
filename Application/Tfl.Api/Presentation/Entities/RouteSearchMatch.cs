using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class RouteSearchMatch
    {
        [JsonProperty("lineId")]
        public string LineId { get; private set;}

        [JsonProperty("mode")]
        public string Mode { get; private set;}

        [JsonProperty("lineName")]
        public string LineName { get; private set;}

        [JsonProperty("lineRouteSection")]
        public ICollection<LineRouteSection> LineRouteSection { get; private set;}

        [JsonProperty("matchedRouteSections")]
        public ICollection<MatchedRouteSections> MatchedRouteSections { get; private set;}

        [JsonProperty("matchedStops")]
        public ICollection<MatchedStop> MatchedStops { get; private set;}

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