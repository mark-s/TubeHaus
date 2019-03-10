using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class StationInterval
    {
        [JsonProperty("id")]
        public string Id { get; private set;}

        [JsonProperty("intervals")]
        public ICollection<Interval> Intervals { get; private set;}


    }
}