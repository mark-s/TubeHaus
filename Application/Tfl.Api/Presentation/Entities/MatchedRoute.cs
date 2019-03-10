using System;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    /// <summary>Description of a Route used in Route search results.</summary>
    
    public class MatchedRoute
    {
        /// <summary>The route code</summary>
        [JsonProperty("routeCode")]
        public string RouteCode { get; private set;}

        /// <summary>Name such as "72"</summary>
        [JsonProperty("name")]
        public string Name { get; private set;}

        /// <summary>Inbound or Outbound</summary>
        [JsonProperty("direction")]
        public string Direction { get; private set;}

        /// <summary>The name of the Origin StopPoint</summary>
        [JsonProperty("originationName")]
        public string OriginationName { get; private set;}

        /// <summary>The name of the Destination StopPoint</summary>
        [JsonProperty("destinationName")]
        public string DestinationName { get; private set;}

        /// <summary>The Id (NaPTAN code) of the Origin StopPoint</summary>
        [JsonProperty("originator")]
        public string Originator { get; private set;}

        /// <summary>The Id (NaPTAN code) or the Destination StopPoint</summary>
        [JsonProperty("destination")]
        public string Destination { get; private set;}

        /// <summary>Regular or Night</summary>
        [JsonProperty("serviceType")]
        public string ServiceType { get; private set;}

        /// <summary>The DateTimeOffset that the Service containing this Route is valid until.</summary>
        [JsonProperty("validTo")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset ValidTo { get; private set;}

        /// <summary>The DateTimeOffset that the Service containing this Route is valid from.</summary>
        [JsonProperty("validFrom")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset ValidFrom { get; private set;}


    }
}