using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class TrainLoading
    {
        /// <summary>The Line Name e.g. "Victoria"</summary>
        [JsonProperty("line")]
        public string Line { get;}

        /// <summary>Direction of the Line e.g. NB, SB, WB etc.</summary>
        [JsonProperty("lineDirection")]
        public string LineDirection { get;}

        /// <summary>Direction displayed on the platform e.g. NB, SB, WB etc.</summary>
        [JsonProperty("platformDirection")]
        public string PlatformDirection { get;}

        /// <summary>Direction in regards to Journey Planner i.e. inbound or outbound</summary>
        [JsonProperty("direction")]
        public string Direction { get;}

        /// <summary>Naptan of the adjacent station</summary>
        [JsonProperty("naptanTo")]
        public string NaptanTo { get;}

        /// <summary>Time in 24hr format with 15 minute intervals e.g. 0500-0515, 0515-0530 etc.</summary>
        [JsonProperty("timeSlice")]
        public string TimeSlice { get;}

        /// <summary>Scale between 1-6, <br/>
        ///1 = Very quiet, 2 = Quiet, 3 = Fairly busy, 4 = Busy, 5 = Very busy, 6 = Exceptionally busy</summary>
        [JsonProperty("value")]
        public int Value { get;}

        public TrainLoading(string line,
            string lineDirection, 
            string platformDirection, 
            string direction,
            string naptanTo, 
            string timeSlice,
            int value)
        {
            Line = line;
            LineDirection = lineDirection;
            PlatformDirection = platformDirection;
            Direction = direction;
            NaptanTo = naptanTo;
            TimeSlice = timeSlice;
            Value = value;
        }
    }
}