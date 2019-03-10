using System;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.Fares
{
    public class FaresPeriod
    {
        [JsonProperty("id")]
        public int Id { get; private set;}

        [JsonProperty("startDate")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset StartDate { get; private set;}

        [JsonProperty("viewableDate")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset ViewableDate { get; private set;}

        [JsonProperty("endDate")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset EndDate { get; private set;}

        [JsonProperty("isFuture")]
        public bool IsFuture { get; private set;}


    }
}