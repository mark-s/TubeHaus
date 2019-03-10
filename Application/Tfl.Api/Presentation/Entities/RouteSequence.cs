using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class RouteSequence
    {
        [JsonProperty("lineId")]
        public string LineId { get; private set;}

        [JsonProperty("lineName")]
        public string LineName { get; private set;}

        [JsonProperty("direction")]
        public string Direction { get; private set;}

        [JsonProperty("isOutboundOnly")]
        public bool IsOutboundOnly { get; private set;}

        [JsonProperty("mode")]
        public string Mode { get; private set;}

        [JsonProperty("lineStrings")]
        public ICollection<string> LineStrings { get; private set;}

        [JsonProperty("stations")]
        public ICollection<MatchedStop> Stations { get; private set;}

        [JsonProperty("stopPointSequences")]
        public ICollection<StopPointSequence> StopPointSequences { get; private set;}

        [JsonProperty("orderedLineRoutes")]
        public ICollection<OrderedRoute> OrderedLineRoutes { get; private set;}


    }
}