using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class GeoCodeSearchMatch
    {
        /// <summary>The type of the place e.g. "street_address"</summary>
        [JsonProperty("types")]
        public ICollection<string> Types { get; private set;}

        /// <summary>A string describing the formatted address of the place. Adds additional context to the place's Name.</summary>
        [JsonProperty("address")]
        public string Address { get; private set;}

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