using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class Bay
    {
        [JsonProperty("bayType")]
        public string BayType { get; private set;}

        [JsonProperty("bayCount")]
        public int BayCount { get; private set;}

        [JsonProperty("free")]
        public int Free { get; private set;}

        [JsonProperty("occupied")]
        public int Occupied { get; private set;}


    }
}