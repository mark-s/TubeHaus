using System;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class PredictionTiming
    {
        [JsonProperty("countdownServerAdjustment")]
        public string CountdownServerAdjustment { get; private set;}

        [JsonProperty("source")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset Source { get; private set;}

        [JsonProperty("insert")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset Insert { get; private set;}

        [JsonProperty("read")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset Read { get; private set;}

        [JsonProperty("sent")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset Sent { get; private set;}

        [JsonProperty("received")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset Received { get; private set;}


    }
}