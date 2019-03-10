using System.Collections.Generic;
using Newtonsoft.Json;
using Tfl.Api.Presentation.Entities.TimeTables;

namespace Tfl.Api.Presentation.Entities
{
    public class TimetableResponse
    {
        [JsonProperty("lineId")]
        public string LineId { get; private set;}

        [JsonProperty("lineName")]
        public string LineName { get; private set;}

        [JsonProperty("direction")]
        public string Direction { get; private set;}

        [JsonProperty("pdfUrl")]
        public string PdfUrl { get; private set;}

        [JsonProperty("stations")]
        public ICollection<MatchedStop> Stations { get; private set;}

        [JsonProperty("stops")]
        public ICollection<MatchedStop> Stops { get; private set;}

        [JsonProperty("timetable")]
        public Timetable Timetable { get; private set;}

        [JsonProperty("disambiguation")]
        public Disambiguation Disambiguation { get; private set;}

        [JsonProperty("statusErrorMessage")]
        public string StatusErrorMessage { get; private set;}


    }
}