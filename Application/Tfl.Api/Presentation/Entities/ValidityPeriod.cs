using System;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    /// <summary>Represents a period for which a planned works is valid.</summary>

    public class ValidityPeriod
    {
        /// <summary>Gets or sets the start date.</summary>
        [JsonProperty("fromDate")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset FromDate { get; private set; }

        /// <summary>Gets or sets the end date.</summary>
        [JsonProperty("toDate")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset ToDate { get; private set; }

        /// <summary>If true is a realtime status rather than planned or info</summary>
        [JsonProperty("isNow")]
        public bool IsNow { get; private set; }


    }
}