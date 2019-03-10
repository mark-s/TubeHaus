using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.AccidentStats
{
    public class Casualty
    {
        [JsonProperty("age")]
        public int Age { get; private set;}

        [JsonProperty("class")]
        public string Class { get; private set;}

        [JsonProperty("severity")]
        public string Severity { get; private set;}

        [JsonProperty("mode")]
        public string Mode { get; private set;}

        [JsonProperty("ageBand")]
        public string AgeBand { get; private set;}


    }
}