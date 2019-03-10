using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.AccidentStats
{
    public class AccidentStatsOrderedSummary
    {
        [JsonProperty("year")]
        public int Year { get; private set;}

        [JsonProperty("borough")]
        public string Borough { get; private set;}

        [JsonProperty("accidents")]
        public int Accidents { get; private set;}


    }
}