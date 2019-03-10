using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class LineModeGroup
    {
        [JsonProperty("modeName")]
        public string ModeName { get; private set;}

        [JsonProperty("lineIdentifier")]
        public ICollection<string> LineIdentifier { get; private set;}


    }
}