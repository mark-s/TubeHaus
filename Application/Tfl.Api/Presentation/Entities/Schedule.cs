using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class Schedule
    {
        [JsonProperty("name")]
        public string Name { get; private set;}

        [JsonProperty("knownJourneys")]
        public ICollection<KnownJourney> KnownJourneys { get; private set;}

        [JsonProperty("firstJourney")]
        public KnownJourney FirstJourney { get; private set;}

        [JsonProperty("lastJourney")]
        public KnownJourney LastJourney { get; private set;}

        [JsonProperty("periods")]
        public ICollection<Period> Periods { get; private set;}


    }
}