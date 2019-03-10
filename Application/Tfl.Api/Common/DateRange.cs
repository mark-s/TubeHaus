using System;
using Newtonsoft.Json;

namespace Tfl.Api.Common
{
    public class DateRange
    {
        [JsonProperty("startDate")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset StartDate { get; private set;}

        [JsonProperty("endDate")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset EndDate { get; private set;}


    }
}