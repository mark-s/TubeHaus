using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.Fares
{
    public class Ticket
    {
        [JsonProperty("passengerType")]
        public string PassengerType { get; private set;}

        [JsonProperty("ticketType")]
        public TicketType TicketType { get; private set;}

        [JsonProperty("ticketTime")]
        public TicketTime TicketTime { get; private set;}

        [JsonProperty("cost")]
        public string Cost { get; private set;}

        [JsonProperty("description")]
        public string Description { get; private set;}

        [JsonProperty("mode")]
        public string Mode { get; private set;}

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; private set;}

        [JsonProperty("messages")]
        public ICollection<Message> Messages { get; private set;}


    }
}