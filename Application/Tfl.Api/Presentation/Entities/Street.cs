using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class Street
    {
        /// <summary>Street name</summary>
        [JsonProperty("name")]
        public string Name { get; private set;}

        /// <summary>Type of road closure. Some example values:<br />
        ///             Open = road is open, not blocked, not closed, not restricted. It maybe that the disruption has been moved out of the carriageway.<br />
        ///             Closure = road is partially blocked, closed or restricted. <br />
        ///             Full Closure = road is fully blocked or closed.</summary>
        [JsonProperty("closure")]
        public string Closure { get; private set;}

        /// <summary>The direction of the disruption on the street. Some example values:<br />
        ///             All Directions<br />
        ///             All Approaches<br />
        ///             Clockwise<br />
        ///             Anti-Clockwise<br />
        ///             Northbound<br />
        ///             Eastbound<br />
        ///             Southbound<br />
        ///             Westbound<br />
        ///             Both Directions</summary>
        [JsonProperty("directions")]
        public string Directions { get; private set;}

        /// <summary>Geographic description of the sections of this street that are affected.</summary>
        [JsonProperty("segments")]
        public ICollection<StreetSegment> Segments { get; private set;}

        /// <summary>The ID from the source system of the disruption that this street belongs to.</summary>
        [JsonProperty("sourceSystemId")]
        public long SourceSystemId { get; private set;}

        /// <summary>The key of the source system of the disruption that this street belongs to.</summary>
        [JsonProperty("sourceSystemKey")]
        public string SourceSystemKey { get; private set;}


    }
}