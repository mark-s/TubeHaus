using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.Fares
{
    public class FareBounds
    {
        [JsonProperty("id")]
        public int Id { get; private set;}

        [JsonProperty("from")]
        public string From { get; private set;}

        [JsonProperty("to")]
        public string To { get; private set;}

        [JsonProperty("via")]
        public string Via { get; private set;}

        [JsonProperty("routeCode")]
        public string RouteCode { get; private set;}

        [JsonProperty("description")]
        public string Description { get; private set;}

        [JsonProperty("displayName")]
        public string DisplayName { get; private set;}

        [JsonProperty("operator")]
        public string Operator { get; private set;}

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; private set;}

        [JsonProperty("isPopularFare")]
        public bool IsPopularFare { get; private set;}

        [JsonProperty("isPopularTravelCard")]
        public bool IsPopularTravelCard { get; private set;}

        [JsonProperty("isTour")]
        public bool IsTour { get; private set;}

        [JsonProperty("messages")]
        public ICollection<Message> Messages { get; private set;}


    }
}