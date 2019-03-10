using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class ChargeConnectorOccupancy
    {
        [JsonProperty("id")]
        public int Id { get; private set;}

        [JsonProperty("sourceSystemPlaceId")]
        public string SourceSystemPlaceId { get; private set;}

        [JsonProperty("status")]
        public string Status { get; private set;}


    }
}