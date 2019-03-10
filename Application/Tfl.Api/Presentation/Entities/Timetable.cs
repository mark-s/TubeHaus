using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class Timetable
    {
        [JsonProperty("departureStopId")]
        public string DepartureStopId { get; private set;}

        [JsonProperty("routes")]
        public ICollection<TimetableRoute> Routes { get; private set;}


    }
}