using System;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
    public class PlannedWork
    {
        [JsonProperty("id")]
        public string Id { get; private set;}

        [JsonProperty("description")]
        public string Description { get; private set;}

        [JsonProperty("createdDate")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset CreatedDateTime { get; private set;}

        [JsonProperty("lastUpdateDateTime")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset LastUpdateDateTime { get; private set;}


    }
}