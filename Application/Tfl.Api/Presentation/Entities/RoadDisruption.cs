using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class RoadDisruption
    {
        /// <summary>Unique identifier for the road disruption</summary>
        [JsonProperty("id")]
        public string Id { get; private set;}

        /// <summary>URL to retrieve this road disruption</summary>
        [JsonProperty("url")]
        public string Url { get; private set;}

        /// <summary>Latitude and longitude (WGS84) of the centroid of the disruption, stored in a geoJSON-formatted string.</summary>
        [JsonProperty("point")]
        public string Point { get; private set;}

        /// <summary>A description of the severity of the disruption.</summary>
        [JsonProperty("severity")]
        public string Severity { get; private set;}

        /// <summary>An ordinal of the disruption based on severity, level of interest and corridor.</summary>
        [JsonProperty("ordinal")]
        public int Ordinal { get; private set;}

        /// <summary>Describes the nature of disruption e.g. Traffic Incidents, Works</summary>
        [JsonProperty("category")]
        public string Category { get; private set;}

        /// <summary>Describes the sub-category of disruption e.g. Collapsed Manhole, Abnormal Load</summary>
        [JsonProperty("subCategory")]
        public string SubCategory { get; private set;}

        /// <summary>Full text of comments describing the disruption, including details of any road closures and diversions, where appropriate.</summary>
        [JsonProperty("comments")]
        public string Comments { get; private set;}

        /// <summary>Text of the most recent update from the LSTCC on the state of the
        ///              disruption, including the current traffic impact and any advice to
        ///              road users.</summary>
        [JsonProperty("currentUpdate")]
        public string CurrentUpdate { get; private set;}

        /// <summary>The time when the last CurrentUpdate description was recorded, 
        ///             or null if no CurrentUpdate has been applied.</summary>
        [JsonProperty("currentUpdateDateTimeOffset")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset CurrentUpdateDateTimeOffset { get; private set;}

        /// <summary>The Ids of affected corridors, if any.</summary>
        [JsonProperty("corridorIds")]
        public ICollection<string> CorridorIds { get; private set;}

        /// <summary>The date and time which the disruption started. For a planned disruption (i.e. planned road works) this date will be in the future.
        ///             For unplanned disruptions, this will default to the date on which the disruption was first recorded, but may be adjusted by the operator.</summary>
        [JsonProperty("startDateTimeOffset")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset StartDateTimeOffset { get; private set;}

        /// <summary>The date and time on which the disruption ended. For planned disruptions, this date will have a valid value. For unplanned 
        ///             disruptions in progress, this field will be omitted.</summary>
        [JsonProperty("endDateTimeOffset")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset EndDateTimeOffset { get; private set;}

        /// <summary>The date and time on which the disruption was last modified in the system. This information can reliably be used by a developer to quickly
        ///             compare two instances of the same disruption to determine if it has been changed.</summary>
        [JsonProperty("lastModifiedTime")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset LastModifiedTime { get; private set;}

        /// <summary>This describes the level of potential impact on traffic operations of the disruption. 
        ///             High = e.g. a one-off disruption on a major or high profile route which will require a high level of operational attention 
        ///             Medium = This is the default value 
        ///             Low = e.g. a frequently occurring disruption which is well known</summary>
        [JsonProperty("levelOfInterest")]
        public string LevelOfInterest { get; private set;}

        /// <summary>Main road name / number (borough) or preset area name where the disruption is located. This might be useful for a map popup where space is limited.</summary>
        [JsonProperty("location")]
        public string Location { get; private set;}

        /// <summary>This describes the status of the disruption.  
        ///             Active = currently in progress 
        ///             Active Long Term = currently in progress and long term
        ///             Scheduled = scheduled to start within the next 180 days
        ///             Recurring Works = planned maintenance works that follow a regular routine or pattern and whose next occurrence is to start within the next 180 days.
        ///             Recently Cleared = recently cleared in the last 24 hours
        ///             Note that the status of Scheduled or Recurring Works disruptions will change to Active when they start, and will change status again when they end.</summary>
        [JsonProperty("status")]
        public string Status { get; private set;}

        /// <summary>Geography version of Point for output as GeoJSON.
        ///             Can not use Geometry in a consistent way as non-TIMS disruptions do not have a polygon</summary>
        [JsonProperty("geography")]
        public DbGeography Geography { get; private set;}

        /// <summary>GeoJSON formatted latitude/longitude (WGS84) pairs forming an enclosed polyline or polygon. The polygon will only be included where affected streets information
        ///             is not available for the disruption, would be inappropriate (e.g. a very large number of streets), or is centred on an area without streets (e.g. a football stadium).</summary>
        [JsonProperty("geometry")]
        public DbGeography Geometry { get; private set;}

        /// <summary>A collection of zero or more streets affected by the disruption.</summary>
        [JsonProperty("streets")]
        public ICollection<Street> Streets { get; private set;}

        /// <summary>True if the disruption is planned on a future date that is open to change</summary>
        [JsonProperty("isProvisional")]
        public bool IsProvisional { get; private set;}

        /// <summary>True if any of the affected Streets have a "Full Closure" status, false otherwise. A RoadDisruption that has HasClosures is considered a 
        ///             Severe or Serious disruption for severity filtering purposes.</summary>
        [JsonProperty("hasClosures")]
        public bool HasClosures { get; private set;}

        /// <summary>The text of any associated link</summary>
        [JsonProperty("linkText")]
        public string LinkText { get; private set;}

        /// <summary>The url of any associated link</summary>
        [JsonProperty("linkUrl")]
        public string LinkUrl { get; private set;}

        /// <summary>Any associated road project</summary>
        [JsonProperty("roadProject")]
        public RoadProject RoadProject { get; private set;}

        /// <summary>TDM Additional properties</summary>
        [JsonProperty("publishStartDate")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset PublishStartDate { get; private set;}

        [JsonProperty("publishEndDate")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset PublishEndDate { get; private set;}

        [JsonProperty("timeFrame")]
        public string TimeFrame { get; private set;}

        [JsonProperty("roadDisruptionLines")]
        public ICollection<RoadDisruptionLine> RoadDisruptionLines { get; private set;}

        [JsonProperty("roadDisruptionImpactAreas")]
        public ICollection<RoadDisruptionImpactArea> RoadDisruptionImpactAreas { get; private set;}

        [JsonProperty("recurringSchedules")]
        public ICollection<RoadDisruptionSchedule> RecurringSchedules { get; private set;}


    }
}