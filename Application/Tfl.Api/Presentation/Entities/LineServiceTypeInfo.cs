using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class LineServiceTypeInfo
    {
        [JsonProperty("name")]
        public string Name { get; private set;  }

        [JsonProperty("uri")]
        public string Uri { get; private set; }


    }
}