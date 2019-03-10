using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class LineStatus
    {
        [JsonProperty("id")]
        public int Id {get; private set;}

        [JsonProperty("lineId")]
        public string LineId {get; private set;}

        [JsonProperty("statusSeverity")]
        public int StatusSeverity {get; private set;}

        [JsonProperty("statusSeverityDescription")]
        public string StatusSeverityDescription {get; private set;}

        [JsonProperty("reason")]
        public string Reason {get; private set;}

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset Created {get; private set;}

        [JsonProperty("modified")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset Modified {get; private set;}

        [JsonProperty("validityPeriods")]
        public IReadOnlyCollection<ValidityPeriod> ValidityPeriods {get; private set;}

        [JsonProperty("disruption")]
        public Disruption Disruption {get; private set;}


    }
}