using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.Fares
{
    public class PassengerType
    {
        [JsonProperty("type")]
        public string Type { get; private set;}

        [JsonProperty("description")]
        public string Description { get; private set;}

        [JsonProperty("displayName")]
        public string DisplayName { get; private set;}

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; private set;}


    }
}