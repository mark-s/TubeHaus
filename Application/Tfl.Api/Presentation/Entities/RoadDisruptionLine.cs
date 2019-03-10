using System;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class RoadDisruptionLine
    {
        [JsonProperty("id")]
        public int Id { get; private set;}

        [JsonProperty("roadDisruptionId")]
        public string RoadDisruptionId { get; private set;}

        [JsonProperty("isDiversion")]
        public bool IsDiversion { get; private set;}

        [JsonProperty("multiLineString")]
        public DbGeography MultiLineString { get; private set;}

        [JsonProperty("startDate")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset StartDate { get; private set;}

        [JsonProperty("endDate")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset EndDate { get; private set;}

        [JsonProperty("startTime")]
        public string StartTime { get; private set;}

        [JsonProperty("endTime")]
        public string EndTime { get; private set;}


    }
}