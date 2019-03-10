using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class RouteSectionNaptanEntrySequence
    {
        [JsonProperty("ordinal")]
        public int Ordinal { get; private set; }

        [JsonProperty("stopPoint")]
        public StopPoint StopPoint { get; private set; }


    }
}