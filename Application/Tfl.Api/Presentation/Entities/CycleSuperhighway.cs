using System;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class CycleSuperhighway
    {
        /// <summary>The Id</summary>
        [JsonProperty("id")]
        public string Id { get; private set;}

        /// <summary>The long label to show on maps when zoomed in</summary>
        [JsonProperty("label")]
        public string Label { get; private set;}

        /// <summary>The short label to show on maps</summary>
        [JsonProperty("labelShort")]
        public string LabelShort { get; private set;}

        /// <summary>A LineString or MultiLineString that forms the route of the highway</summary>
        [JsonProperty("geography")]
        public DbGeography Geography { get; private set;}

        /// <summary>True if the route is split into segments</summary>
        [JsonProperty("segmented")]
        public bool Segmented { get; private set;}

        /// <summary>When the data was last updated</summary>
        [JsonProperty("modified")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset Modified { get; private set;}

        /// <summary>Cycle route status i.e Proposed, Existing etc</summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CycleSuperhighwayStatus Status { get; private set;}

        /// <summary>Type of cycle route e.g CycleSuperhighways, Quietways, MiniHollands etc</summary>
        [JsonProperty("routeType")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CycleSuperhighwayRouteType RouteType { get; private set;}


    }
}