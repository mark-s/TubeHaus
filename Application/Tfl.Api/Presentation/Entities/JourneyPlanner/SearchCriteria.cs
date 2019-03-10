using System;
using Newtonsoft.Json;


namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
    public class SearchCriteria
    {
        [JsonProperty("DateTime")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset DateTime { get; private set;}

        [JsonProperty("DateTimeType")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SearchCriteriaDateTimeType DateTimeType { get; private set;}

        [JsonProperty("timeAdjustments")]
        public TimeAdjustments TimeAdjustments { get; private set;}


    }
}