using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
    public class JourneyFare
    {
        [JsonProperty("totalCost")]
        public int TotalCost { get; private set;}

        [JsonProperty("fares")]
        public ICollection<Fare> Fares { get; private set;}

        [JsonProperty("caveats")]
        public ICollection<FareCaveat> Caveats { get; private set;}


    }
}