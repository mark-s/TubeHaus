using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
    public class FareTap
    {
        [JsonProperty("atcoCode")]
        public string AtcoCode { get; private set;}

        [JsonProperty("tapDetails")]
        public FareTapDetails TapDetails { get; private set;}


    }
}