using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class Line
    {
        [JsonProperty("id")]
        public string Id { get;  private set; }

        [JsonProperty("name")]
        public string Name { get;  private set; }

        [JsonProperty("modeName")]
        public string ModeName { get;  private set; }

        [JsonProperty("disruptions")]
        public IReadOnlyCollection<Disruption> Disruptions { get;  private set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset Created { get;  private set; }

        [JsonProperty("modified")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset Modified { get;  private set; }

        [JsonProperty("lineStatuses")]
        public IReadOnlyCollection<LineStatus> LineStatuses { get;  private set; }

        [JsonProperty("routeSections")]
        public IReadOnlyCollection<MatchedRoute> RouteSections { get;  private set; }

        [JsonProperty("serviceTypes")]
        public IReadOnlyCollection<LineServiceTypeInfo> ServiceTypes { get;  private set; }

        [JsonProperty("crowding")]
        public Crowding Crowding { get;  private set; }


    }
}