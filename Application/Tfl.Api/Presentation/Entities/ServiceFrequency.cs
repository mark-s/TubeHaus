using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class ServiceFrequency
    {
        [JsonProperty("lowestFrequency")]
        public double LowestFrequency { get; private set;}

        [JsonProperty("highestFrequency")]
        public double HighestFrequency { get; private set;}


    }
}