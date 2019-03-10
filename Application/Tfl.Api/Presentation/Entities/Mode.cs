using System.Diagnostics;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{

    [DebuggerDisplay("{" + nameof(ModeName) + "}")]
    public class Mode
    {
        [JsonProperty("isTflService")]
        public bool IsTflService { get;  }

        [JsonProperty("isFarePaying")]
        public bool IsFarePaying { get; }

        [JsonProperty("isScheduledService")]
        public bool IsScheduledService { get;  }

        [JsonProperty("modeName")]
        public string ModeName { get;  }

        public Mode(bool isTflService, bool isFarePaying, bool isScheduledService, string modeName)
        {
            IsTflService = isTflService;
            IsFarePaying = isFarePaying;
            IsScheduledService = isScheduledService;
            ModeName = modeName;
        }
    }
}