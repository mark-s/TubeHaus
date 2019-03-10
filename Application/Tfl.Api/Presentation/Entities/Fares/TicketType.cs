using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.Fares
{
    public class TicketType
    {
        [JsonProperty("type")]
        public string Type { get; private set;}

        [JsonProperty("description")]
        public string Description { get; private set;}


    }
}