using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    /// <summary>Represents a disruption to a route within the transport network.</summary>

    public class Disruption
    {
        /// <summary>Gets or sets the category of this disruption.</summary>
        [JsonProperty("category")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DisruptionCategory Category { get;  private set;}

        /// <summary>Gets or sets the disruption type of this disruption.</summary>
        [JsonProperty("type")]
        public string Type { get;  private set;}

        /// <summary>Gets or sets the description of the category.</summary>
        [JsonProperty("categoryDescription")]
        public string CategoryDescription { get;  private set;}

        /// <summary>Gets or sets the description of this disruption.</summary>
        [JsonProperty("description")]
        public string Description { get;  private set;}

        /// <summary>Gets or sets the summary of this disruption.</summary>
        [JsonProperty("summary")]
        public string Summary { get;  private set;}

        /// <summary>Gets or sets the additionaInfo of this disruption.</summary>
        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get;  private set;}

        /// <summary>Gets or sets the date/time when this disruption was created.</summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset Created { get;  private set;}

        /// <summary>Gets or sets the date/time when this disruption was last updated.</summary>
        [JsonProperty("lastUpdate")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset LastUpdate { get;  private set;}

        /// <summary>Gets or sets the routes affected by this disruption</summary>
        [JsonProperty("affectedRoutes")]
        public ICollection<RouteSection> AffectedRoutes { get;  private set;}

        /// <summary>Gets or sets the stops affected by this disruption</summary>
        [JsonProperty("affectedStops")]
        public ICollection<StopPoint> AffectedStops { get;  private set;}

        /// <summary>Text describing the closure type</summary>
        [JsonProperty("closureText")]
        public string ClosureText { get;  private set;}


    }
}