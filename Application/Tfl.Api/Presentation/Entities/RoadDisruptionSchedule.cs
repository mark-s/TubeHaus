using System;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class RoadDisruptionSchedule
    {
        [JsonProperty("startTime")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset StartTime { get; private set;}

        [JsonProperty("endTime")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset EndTime { get; private set;}


    }
}