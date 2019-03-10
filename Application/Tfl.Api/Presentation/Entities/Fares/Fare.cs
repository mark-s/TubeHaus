using System;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.Fares
{
    public class Fare
    {
        [JsonProperty("id")]
        public int Id { get; private set;}

        [JsonProperty("passengerType")]
        public string PassengerType { get; private set;}

        [JsonProperty("validFrom")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset ValidFrom { get; private set;}

        [JsonProperty("validUntil")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset ValidUntil { get; private set;}

        [JsonProperty("ticketTime")]
        public string TicketTime { get; private set;}

        [JsonProperty("ticketType")]
        public string TicketType { get; private set;}

        [JsonProperty("cost")]
        public string Cost { get; private set;}

        [JsonProperty("cap")]
        public double Cap { get; private set;}

        [JsonProperty("description")]
        public string Description { get; private set;}

        [JsonProperty("zone")]
        public string Zone { get; private set;}

        [JsonProperty("mode")]
        public string Mode { get; private set;}


    }
}