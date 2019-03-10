using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
    public class RouteOption
    {
        /// <summary>The Id of the route</summary>
        [JsonProperty("id")]
        public string Id { get; private set;}

        /// <summary>Name such as "72"</summary>
        [JsonProperty("name")]
        public string Name { get; private set;}

        [JsonProperty("directions")]
        public ICollection<string> Directions { get; private set;}

        /// <summary>The line identifier (e.g. District Line), from where you can obtain line status information e.g. the rainbow board status "good service".</summary>
        [JsonProperty("lineIdentifier")]
        public Identifier LineIdentifier { get; private set;}


    }
}