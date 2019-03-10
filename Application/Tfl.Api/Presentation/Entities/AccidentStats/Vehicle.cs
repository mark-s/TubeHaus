using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.AccidentStats
{
    public class Vehicle
    {
        [JsonProperty("type")]
        public string Type { get; private set;}


    }
}