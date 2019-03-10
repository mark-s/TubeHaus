using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
    /// <summary>A DTO representing a list of possible journeys.</summary>
    
    public class ItineraryResult
    {
        [JsonProperty("journeys")]
        public ICollection<Journey> Journeys { get; private set;}

        [JsonProperty("lines")]
        public ICollection<Line> Lines { get; private set;}

        [JsonProperty("cycleHireDockingStationData")]
        public JourneyPlannerCycleHireDockingStationData CycleHireDockingStationData { get; private set;}

        [JsonProperty("stopMessages")]
        public ICollection<string> StopMessages { get; private set;}

        [JsonProperty("recommendedMaxAgeMinutes")]
        public int RecommendedMaxAgeMinutes { get; private set;}

        [JsonProperty("searchCriteria")]
        public SearchCriteria SearchCriteria { get; private set;}

        [JsonProperty("journeyVector")]
        public JourneyVector JourneyVector { get; private set;}


    }
}