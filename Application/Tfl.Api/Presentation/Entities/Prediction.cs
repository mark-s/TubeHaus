using System;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    /// <summary>DTO to capture the prediction details</summary>
    
    public class Prediction
    {
        /// <summary>The identitier for the prediction</summary>
        [JsonProperty("id")]
        public string Id { get; private set;}

        /// <summary>The type of the operation (1: is new or has been updated, 2: should be deleted from any client cache)</summary>
        [JsonProperty("operationType")]
        public int OperationType { get; private set;}

        /// <summary>The actual vehicle in transit (for train modes, the leading car of the rolling set)</summary>
        [JsonProperty("vehicleId")]
        public string VehicleId { get; private set;}

        /// <summary>Identifier for the prediction</summary>
        [JsonProperty("naptanId")]
        public string NaptanId { get; private set;}

        /// <summary>Station name</summary>
        [JsonProperty("stationName")]
        public string StationName { get; private set;}

        /// <summary>Unique identifier for the Line</summary>
        [JsonProperty("lineId")]
        public string LineId { get; private set;}

        /// <summary>Line Name</summary>
        [JsonProperty("lineName")]
        public string LineName { get; private set;}

        /// <summary>Platform name (for bus, this is the stop letter)</summary>
        [JsonProperty("platformName")]
        public string PlatformName { get; private set;}

        /// <summary>Direction (unified to inbound/outbound)</summary>
        [JsonProperty("direction")]
        public string Direction { get; private set;}

        /// <summary>Bearing (between 0 to 359)</summary>
        [JsonProperty("bearing")]
        public string Bearing { get; private set;}

        /// <summary>Naptan Identifier for the prediction's destination</summary>
        [JsonProperty("destinationNaptanId")]
        public string DestinationNaptanId { get; private set;}

        /// <summary>Name of the destination</summary>
        [JsonProperty("destinationName")]
        public string DestinationName { get; private set;}

        /// <summary>Timestamp for when the prediction was inserted/modified (source column drives what objects are broadcast on each iteration)</summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset Timestamp { get; private set;}

        /// <summary>Prediction of the Time to station in seconds</summary>
        [JsonProperty("timeToStation")]
        public int TimeToStation { get; private set;}

        /// <summary>The current location of the vehicle.</summary>
        [JsonProperty("currentLocation")]
        public string CurrentLocation { get; private set;}

        /// <summary>Routing information or other descriptive text about the path of the vehicle towards the destination</summary>
        [JsonProperty("towards")]
        public string Towards { get; private set;}

        /// <summary>The expected arrival time of the vehicle at the stop/station</summary>
        [JsonProperty("expectedArrival")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset ExpectedArrival { get; private set;}

        /// <summary>The expiry time for the prediction</summary>
        [JsonProperty("timeToLive")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset TimeToLive { get; private set;}

        /// <summary>The mode name of the station/line the prediction relates to</summary>
        [JsonProperty("modeName")]
        public string ModeName { get; private set;}

        /// <summary>Keep the original timestamp from MongoDb fo debugging purposes</summary>
        [JsonProperty("timing")]
        public PredictionTiming Timing { get; private set;}


    }
}