using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class LineGroup
    {
        [JsonProperty("naptanIdReference")]
        public string NaptanIdReference { get; private set;}

        [JsonProperty("stationAtcoCode")]
        public string StationAtcoCode { get; private set;}

        [JsonProperty("lineIdentifier")]
        public ICollection<string> LineIdentifier { get; private set;}


    }
}