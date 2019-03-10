using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class PathAttribute
    {
        [JsonProperty("name")]
        public string Name { get; private set;}

        [JsonProperty("value")]
        public string Value { get; private set;}


    }
}