using System;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class AdditionalProperties
    {
        [JsonProperty("category")]
        public string Category { get; private set;}

        [JsonProperty("key")]
        public string Key { get; private set;}

        [JsonProperty("sourceSystemKey")]
        public string SourceSystemKey { get; private set;}

        [JsonProperty("value")]
        public string Value { get; private set;}

        [JsonProperty("modified")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset Modified { get; private set;}


    }
}