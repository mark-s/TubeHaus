using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class TimetableRoute
    {
        [JsonProperty("stationIntervals")]
        public ICollection<StationInterval> StationIntervals { get; private set;}

        [JsonProperty("schedules")]
        public ICollection<Schedule> Schedules { get; private set;}


    }
}