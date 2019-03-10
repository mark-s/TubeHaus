using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
    public class Fare
    {
        [JsonProperty("lowZone")]
        public int LowZone { get; private set;}

        [JsonProperty("highZone")]
        public int HighZone { get; private set;}

        [JsonProperty("cost")]
        public int Cost { get; private set;}

        [JsonProperty("chargeProfileName")]
        public string ChargeProfileName { get; private set;}

        [JsonProperty("isHopperFare")]
        public bool IsHopperFare { get; private set;}

        [JsonProperty("chargeLevel")]
        public string ChargeLevel { get; private set;}

        [JsonProperty("peak")]
        public int Peak { get; private set;}

        [JsonProperty("offPeak")]
        public int OffPeak { get; private set;}

        [JsonProperty("taps")]
        public ICollection<FareTap> Taps { get; private set;}


    }
}