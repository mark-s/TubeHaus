using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.Fares
{
    public class FaresSection
    {
        [JsonProperty("header")]
        public string Header { get; private set;}

        [JsonProperty("index")]
        public int Index { get; private set;}

        [JsonProperty("rows")]
        public ICollection<FareDetails> Rows { get; private set;}

        [JsonProperty("messages")]
        public ICollection<Message> Messages { get; private set;}


    }
}