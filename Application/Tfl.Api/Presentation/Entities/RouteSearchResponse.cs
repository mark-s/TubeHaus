using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class RouteSearchResponse
    {
        [JsonProperty("input")]
        public string Input { get; private set;}

        [JsonProperty("searchMatches")]
        public ICollection<RouteSearchMatch> SearchMatches { get; private set;}


    }
}