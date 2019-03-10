using Newtonsoft.Json;


namespace Tfl.Api.Presentation.Entities
{
    public class Period
    {
        [JsonProperty("type")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PeriodType Type { get; private set;}

        [JsonProperty("fromTime")]
        public TwentyFourHourClockTime FromTime { get; private set;}

        [JsonProperty("toTime")]
        public TwentyFourHourClockTime ToTime { get; private set;}

        [JsonProperty("frequency")]
        public ServiceFrequency Frequency { get; private set;}


    }
}