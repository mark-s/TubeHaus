using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class RouteSection
    {
        /// <summary>The Id of the route</summary>
        [JsonProperty("id")]
        public string Id { get;  private set;}

        /// <summary>The Id of the Line</summary>
        [JsonProperty("lineId")]
        public string LineId { get;  private set;}

        /// <summary>The route code</summary>
        [JsonProperty("routeCode")]
        public string RouteCode { get;  private set;}

        /// <summary>Name such as "72"</summary>
        [JsonProperty("name")]
        public string Name { get;  private set;}

        /// <summary>The co-ordinates of the route's path as a geoJSON lineString</summary>
        [JsonProperty("lineString")]
        public string LineString { get;  private set;}

        /// <summary>Inbound or Outbound</summary>
        [JsonProperty("direction")]
        public string Direction { get;  private set;}

        /// <summary>The name of the Origin StopPoint</summary>
        [JsonProperty("originationName")]
        public string OriginationName { get;  private set;}

        /// <summary>The name of the Destination StopPoint</summary>
        [JsonProperty("destinationName")]
        public string DestinationName { get;  private set;}

        /// <summary>The DateTimeOffset that the Service containing this Route is valid until.</summary>
        [JsonProperty("validTo")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset ValidTo { get;  private set;}

        /// <summary>The DateTimeOffset that the Service containing this Route is valid from.</summary>
        [JsonProperty("validFrom")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset ValidFrom { get;  private set;}

        [JsonProperty("routeSectionNaptanEntrySequence")]
        public ICollection<RouteSectionNaptanEntrySequence> RouteSectionNaptanEntrySequence { get;  private set;}


    }
}