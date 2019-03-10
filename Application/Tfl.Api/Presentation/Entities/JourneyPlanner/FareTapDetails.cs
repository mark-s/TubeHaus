using System;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
    public class FareTapDetails
    {
        [JsonProperty("modeType")]
        public string ModeType { get; private set;}

        [JsonProperty("validationType")]
        public string ValidationType { get; private set;}

        [JsonProperty("hostDeviceType")]
        public string HostDeviceType { get; private set;}

        [JsonProperty("busRouteId")]
        public string BusRouteId { get; private set;}

        [JsonProperty("nationalLocationCode")]
        public int NationalLocationCode { get; private set;}

        [JsonProperty("tapTimestamp")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset TapTimestamp { get; private set;}


    }
}