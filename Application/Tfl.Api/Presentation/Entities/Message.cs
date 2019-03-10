using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class Message
    {
        [JsonProperty("bulletOrder")]
        public int BulletOrder { get; private set;}

        [JsonProperty("header")]
        public bool Header { get; private set;}

        [JsonProperty("messageText")]
        public string MessageText { get; private set;}

        [JsonProperty("linkText")]
        public string LinkText { get; private set;}

        [JsonProperty("url")]
        public string Url { get; private set;}


    }
}