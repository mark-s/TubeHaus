using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class StatusSeverity
    {
        [JsonProperty("modeName")]
        public string ModeName { get; }

        [JsonProperty("severityLevel")]
        public int SeverityLevel { get; }

        [JsonProperty("description")]
        public string Description { get;}

        public StatusSeverity(string modeName, int severityLevel, string description)
        {
            ModeName = modeName;
            SeverityLevel = severityLevel;
            Description = description;
        }
    }
}