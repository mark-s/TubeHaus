using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class CarParkOccupancy
    {
        [JsonProperty("id")]
        public string Id { get; private set;}

        [JsonProperty("bays")]
        public ICollection<Bay> Bays { get; private set;}

        [JsonProperty("name")]
        public string Name { get; private set;}

        [JsonProperty("carParkDetailsUrl")]
        public string CarParkDetailsUrl { get; private set;}


    }
}