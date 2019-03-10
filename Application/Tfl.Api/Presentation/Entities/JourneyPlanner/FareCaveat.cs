using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
    public class FareCaveat
    {
        [JsonProperty("text")]
        public string Text { get; private set;}

        [JsonProperty("type")]
        public string Type { get; private set;}


    }
}