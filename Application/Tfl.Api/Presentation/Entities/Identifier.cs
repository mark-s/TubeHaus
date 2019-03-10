using Newtonsoft.Json;


namespace Tfl.Api.Presentation.Entities
{
    public class Identifier
    {
        [JsonProperty("id")]
        public string Id { get; }

        [JsonProperty("name")]
        public string Name { get; }

        [JsonProperty("uri")]
        public string Uri { get; }

        [JsonProperty("fullName")]
        public string FullName { get; }

        [JsonProperty("type")]
        public string Type { get; }

        [JsonProperty("crowding")]
        public Crowding Crowding { get; }

        [JsonProperty("routeType")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public IdentifierRouteType RouteType { get; }

        [JsonProperty("status")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public IdentifierStatus Status { get; }

        public Identifier(string id,
            string name,
            string uri, 
            string fullName,
            string type,
            Crowding crowding,
            IdentifierRouteType routeType, 
            IdentifierStatus status)
        {
            Id = id;
            Name = name;
            Uri = uri;
            FullName = fullName;
            Type = type;
            Crowding = crowding;
            RouteType = routeType;
            Status = status;
        }
    }
}