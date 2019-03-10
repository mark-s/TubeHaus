using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.TimeTables
{
    public class DisambiguationOption
    {
        [JsonProperty("description")]
        public string Description { get; private set;}

        [JsonProperty("uri")]
        public string Uri { get; private set;}


    }
}