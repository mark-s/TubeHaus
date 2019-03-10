using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class SearchMatch
    {
        [JsonProperty("id")]
        public string Id { get; private set;}

        [JsonProperty("url")]
        public string Url { get; private set;}

        [JsonProperty("name")]
        public string Name { get; private set;}

        [JsonProperty("lat")]
        public double Lat { get; private set;}

        [JsonProperty("lon")]
        public double Lon { get; private set;}


    }
}