using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class LineRouteSection
    {
        [JsonProperty("routeId")]
        public int RouteId { get; private set;}

        [JsonProperty("direction")]
        public string Direction { get; private set;}

        [JsonProperty("destination")]
        public string Destination { get; private set;}

        [JsonProperty("fromStation")]
        public string FromStation { get; private set;}

        [JsonProperty("toStation")]
        public string ToStation { get; private set;}

        [JsonProperty("serviceType")]
        public string ServiceType { get; private set;}

        [JsonProperty("vehicleDestinationText")]
        public string VehicleDestinationText { get; private set;}


    }
}