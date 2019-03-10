using System.Collections.Generic;
using Newtonsoft.Json;
using Tfl.Api.Common.JourneyPlanner;

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
    public class Path
    {
        [JsonProperty("lineString")]
        public string LineString { get; private set;}

        [JsonProperty("stopPoints")]
        public ICollection<Identifier> StopPoints { get; private set;}

        [JsonProperty("elevation")]
        public ICollection<JpElevation> Elevation { get; private set;}


    }
}