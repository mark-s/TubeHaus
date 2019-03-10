using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class Redirect
    {
        [JsonProperty("shortUrl")]
        public string ShortUrl { get; private set;}

        [JsonProperty("longUrl")]
        public string LongUrl { get; private set;}

        [JsonProperty("active")]
        public bool Active { get; private set;}


    }
}