using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class PlaceCategory
    {
        [JsonProperty("category")]
        public string Category { get; private set;}

        [JsonProperty("availableKeys")]
        public ICollection<string> AvailableKeys { get; private set;}


    }
}