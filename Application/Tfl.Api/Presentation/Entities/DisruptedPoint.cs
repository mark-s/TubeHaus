using System;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class DisruptedPoint
    {
        [JsonProperty("atcoCode")]
        public string AtcoCode { get; private set;}

        [JsonProperty("fromDate")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset FromDate { get; private set;}

        [JsonProperty("toDate")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset ToDate { get; private set;}

        [JsonProperty("description")]
        public string Description { get; private set;}

        [JsonProperty("commonName")]
        public string CommonName { get; private set;}

        [JsonProperty("type")]
        public string Type { get; private set;}

        [JsonProperty("mode")]
        public string Mode { get; private set;}

        [JsonProperty("stationAtcoCode")]
        public string StationAtcoCode { get; private set;}

        [JsonProperty("appearance")]
        public string Appearance { get; private set;}

        [JsonProperty("additionalInformation")]
        public string AdditionalInformation { get; private set;}


    }
}