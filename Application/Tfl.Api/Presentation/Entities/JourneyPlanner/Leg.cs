using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
    public class Leg
    {
        [JsonProperty("duration")]
        public int Duration { get; private set;}

        [JsonProperty("speed")]
        public string Speed { get; private set;}

        /// <summary>Describes the action the user need to take for this section, E.g. "walk to the
        ///             district line"</summary>
        [JsonProperty("instruction")]
        public Instruction Instruction { get; private set;}

        [JsonProperty("obstacles")]
        public ICollection<Obstacle> Obstacles { get; private set;}

        [JsonProperty("departureTime")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset DepartureTime { get; private set;}

        [JsonProperty("arrivalTime")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset ArrivalTime { get; private set;}

        [JsonProperty("departurePoint")]
        public Point DeparturePoint { get; private set;}

        [JsonProperty("arrivalPoint")]
        public Point ArrivalPoint { get; private set;}

        [JsonProperty("path")]
        public Path Path { get; private set;}

        [JsonProperty("routeOptions")]
        public ICollection<RouteOption> RouteOptions { get; private set;}

        [JsonProperty("mode")]
        public Identifier Mode { get; private set;}

        [JsonProperty("disruptions")]
        public ICollection<Disruption> Disruptions { get; private set;}

        [JsonProperty("plannedWorks")]
        public ICollection<PlannedWork> PlannedWorks { get; private set;}

        [JsonProperty("distance")]
        public double Distance { get; private set;}

        [JsonProperty("isDisrupted")]
        public bool IsDisrupted { get; private set;}

        [JsonProperty("hasFixedLocations")]
        public bool HasFixedLocations { get; private set;}


    }
}