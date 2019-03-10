using System;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class StopPointRouteSection
    {
        [JsonProperty("naptanId")]
        public string NaptanId { get; private set;}

        [JsonProperty("lineId")]
        public string LineId { get; private set;}

        [JsonProperty("mode")]
        public string Mode { get; private set;}

        [JsonProperty("validFrom")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset ValidFrom { get; private set;}

        [JsonProperty("validTo")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset ValidTo { get; private set;}

        [JsonProperty("direction")]
        public string Direction { get; private set;}

        [JsonProperty("routeSectionName")]
        public string RouteSectionName { get; private set;}

        [JsonProperty("lineString")]
        public string LineString { get; private set;}

        [JsonProperty("isActive")]
        public bool IsActive { get; private set;}

        [JsonProperty("serviceType")]
        public string ServiceType { get; private set;}

        [JsonProperty("vehicleDestinationText")]
        public string VehicleDestinationText { get; private set;}

        [JsonProperty("destinationName")]
        public string DestinationName { get; private set;}


    }
}