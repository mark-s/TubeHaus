using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class OrderedRoute
    {
        [JsonProperty("name")]
        public string Name { get; private set;}

        [JsonProperty("naptanIds")]
        public ICollection<string> NaptanIds { get; private set;}

        [JsonProperty("serviceType")]
        public string ServiceType { get; private set;}


    }
}