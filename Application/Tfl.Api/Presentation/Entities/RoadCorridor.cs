using System;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class RoadCorridor
    {
        /// <summary>The Id of the Corridor e.g. "A406"</summary>
        [JsonProperty("id")]
        public string Id { get; private set;}

        /// <summary>The display name of the Corridor e.g. "North Circular (A406)". This
        ///             may be identical to the Id.</summary>
        [JsonProperty("displayName")]
        public string DisplayName { get; private set;}

        /// <summary>The group name of the Corridor e.g. "Central London". Most corridors are not grouped, in which case this field can be null.</summary>
        [JsonProperty("group")]
        public string Group { get; private set;}

        /// <summary>Standard multi-mode status severity code</summary>
        [JsonProperty("statusSeverity")]
        public string StatusSeverity { get; private set;}

        /// <summary>Description of the status severity as applied to RoadCorridors</summary>
        [JsonProperty("statusSeverityDescription")]
        public string StatusSeverityDescription { get; private set;}

        /// <summary>The Bounds of the Corridor, given by the south-east followed by the north-west co-ordinate
        ///             pair in geoJSON format e.g. "[[-1.241531,51.242151],[1.641223,53.765721]]"</summary>
        [JsonProperty("bounds")]
        public string Bounds { get; private set;}

        /// <summary>The Envelope of the Corridor, given by the corner co-ordinates of a rectangular (four-point) polygon
        ///             in geoJSON format e.g. "[[-1.241531,51.242151],[-1.241531,53.765721],[1.641223,53.765721],[1.641223,51.242151]]"</summary>
        [JsonProperty("envelope")]
        public string Envelope { get; private set;}

        /// <summary>The start of the period over which status has been aggregated, or null if this is the current corridor status.</summary>
        [JsonProperty("statusAggregationStartDate")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset StatusAggregationStartDate { get; private set;}

        /// <summary>The end of the period over which status has been aggregated, or null if this is the current corridor status.</summary>
        [JsonProperty("statusAggregationEndDate")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset StatusAggregationEndDate { get; private set;}

        /// <summary>URL to retrieve this Corridor.</summary>
        [JsonProperty("url")]
        public string Url { get; private set;}


    }
}