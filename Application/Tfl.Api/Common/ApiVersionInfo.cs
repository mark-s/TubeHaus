using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Common
{
    public class ApiVersionInfo
    {
        [JsonProperty("label")]
        public string Label { get; private set;}

        [JsonProperty("timestamp")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset Timestamp { get; private set;}

        [JsonProperty("version")]
        public string Version { get; private set;}

        [JsonProperty("assemblies")]
        public ICollection<string> Assemblies { get; private set;}


    }
}