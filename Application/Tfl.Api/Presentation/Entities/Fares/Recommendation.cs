using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.Fares
{
    public class Recommendation
    {
        [JsonProperty("id")]
        public int Id { get; private set;}

        [JsonProperty("rule")]
        public int Rule { get; private set;}

        [JsonProperty("rank")]
        public int Rank { get; private set;}

        [JsonProperty("fareType")]
        public string FareType { get; private set;}

        [JsonProperty("product")]
        public string Product { get; private set;}

        [JsonProperty("ticketType")]
        public string TicketType { get; private set;}

        [JsonProperty("ticketTime")]
        public string TicketTime { get; private set;}

        [JsonProperty("productType")]
        public string ProductType { get; private set;}

        [JsonProperty("discountCard")]
        public string DiscountCard { get; private set;}

        [JsonProperty("zones")]
        public string Zones { get; private set;}

        [JsonProperty("cost")]
        public string Cost { get; private set;}

        [JsonProperty("priceDescription")]
        public string PriceDescription { get; private set;}

        [JsonProperty("priceComparison")]
        public string PriceComparison { get; private set;}

        [JsonProperty("recommendedTopUp")]
        public string RecommendedTopUp { get; private set;}

        [JsonProperty("notes")]
        public ICollection<Message> Notes { get; private set;}

        [JsonProperty("keyFeatures")]
        public ICollection<Message> KeyFeatures { get; private set;}

        [JsonProperty("gettingYourTicket")]
        public ICollection<Message> GettingYourTicket { get; private set;}

        [JsonProperty("singleFare")]
        public double SingleFare { get; private set;}


    }
}