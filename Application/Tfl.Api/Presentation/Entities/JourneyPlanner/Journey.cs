using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
    /// <summary>Object that represents an end to end journey (see schematic).</summary>
    
    public class Journey
    {
        [JsonProperty("startDateTime")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset StartDateTime { get; private set;}

        [JsonProperty("duration")]
        public int Duration { get; private set;}

        [JsonProperty("arrivalDateTime")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset ArrivalDateTime { get; private set;}

        [JsonProperty("legs")]
        public ICollection<Leg> Legs { get; private set;}

        [JsonProperty("fare")]
        public JourneyFare Fare { get; private set;}


    }
}