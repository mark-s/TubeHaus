using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.Fares
{
    public class FareDetails
    {
        [JsonProperty("boundsId")]
        public int BoundsId { get; private set;}

        [JsonProperty("startDate")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset StartDate { get; private set;}

        [JsonProperty("endDate")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset EndDate { get; private set;}

        [JsonProperty("mode")]
        public string Mode { get; private set;}

        [JsonProperty("passengerType")]
        public string PassengerType { get; private set;}

        [JsonProperty("from")]
        public string From { get; private set;}

        [JsonProperty("to")]
        public string To { get; private set;}

        [JsonProperty("fromStation")]
        public string FromStation { get; private set;}

        [JsonProperty("toStation")]
        public string ToStation { get; private set;}

        [JsonProperty("via")]
        public string Via { get; private set;}

        [JsonProperty("routeCode")]
        public string RouteCode { get; private set;}

        [JsonProperty("displayName")]
        public string DisplayName { get; private set;}

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; private set;}

        [JsonProperty("routeDescription")]
        public string RouteDescription { get; private set;}

        [JsonProperty("validatorInformation")]
        public string ValidatorInformation { get; private set;}

        [JsonProperty("operator")]
        public string Operator { get; private set;}

        [JsonProperty("specialFare")]
        public bool SpecialFare { get; private set;}

        [JsonProperty("throughFare")]
        public bool ThroughFare { get; private set;}

        [JsonProperty("isTour")]
        public bool IsTour { get; private set;}

        [JsonProperty("ticketsAvailable")]
        public ICollection<Ticket> TicketsAvailable { get; private set;}

        [JsonProperty("messages")]
        public ICollection<Message> Messages { get; private set;}


    }
}