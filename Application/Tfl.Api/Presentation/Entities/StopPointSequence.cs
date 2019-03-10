using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class StopPointSequence
    {
        [JsonProperty("lineId")]
        public string LineId { get; private set;}

        [JsonProperty("lineName")]
        public string LineName { get; private set;}

        [JsonProperty("direction")]
        public string Direction { get; private set;}

        /// <summary>The id of this branch.</summary>
        [JsonProperty("branchId")]
        public int BranchId { get; private set;}

        /// <summary>The ids of the next branch(es) in the sequence. Note that the next and previous branch id can be<br />
        ///             identical in the case of a looped route e.g. the Circle line.</summary>
        [JsonProperty("nextBranchIds")]
        public ICollection<int> NextBranchIds { get; private set;}

        /// <summary>The ids of the previous branch(es) in the sequence. Note that the next and previous branch id can be<br />
        ///             identical in the case of a looped route e.g. the Circle line.</summary>
        [JsonProperty("prevBranchIds")]
        public ICollection<int> PrevBranchIds { get; private set;}

        [JsonProperty("stopPoint")]
        public ICollection<MatchedStop> StopPoint { get; private set;}

        [JsonProperty("serviceType")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public StopPointSequenceServiceType ServiceType { get; private set;}


    }
}