using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class Instruction
    {
        [JsonProperty("summary")]
        public string Summary { get; private set;}

        [JsonProperty("detailed")]
        public string Detailed { get; private set;}

        [JsonProperty("steps")]
        public ICollection<InstructionStep> Steps { get; private set;}


    }
}