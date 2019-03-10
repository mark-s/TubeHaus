using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class PassengerFlow
    {
        /// <summary>Time in 24hr format with 15 minute intervals e.g. 0500-0515, 0515-0530 etc.</summary>
        [JsonProperty("timeSlice")]
        public string TimeSlice { get;  }

        /// <summary>Count of passenger flow towards a platform</summary>
        [JsonProperty("value")]
        public int Value { get;  }

        public PassengerFlow(string timeSlice, int value)
        {
            TimeSlice = timeSlice;
            Value = value;
        }
    }
}