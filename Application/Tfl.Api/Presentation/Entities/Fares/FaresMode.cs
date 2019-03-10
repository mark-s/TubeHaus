using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.Fares
{
    public class FaresMode
    {
        [JsonProperty("id")]
        public int Id { get; private set;}

        [JsonProperty("name")]
        public string Name { get; private set;}

        [JsonProperty("description")]
        public string Description { get; private set;}


    }
}