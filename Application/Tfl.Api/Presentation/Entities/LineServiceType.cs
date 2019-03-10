using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class LineServiceType
    {
        [JsonProperty("lineName")]
        public string LineName { get; private set;}

        [JsonProperty("lineSpecificServiceTypes")]
        public ICollection<LineSpecificServiceType> LineSpecificServiceTypes { get; private set;}


    }
}