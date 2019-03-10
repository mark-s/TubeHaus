using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.TimeTables
{
    public class Disambiguation
    {
        [JsonProperty("disambiguationOptions")]
        public ICollection<DisambiguationOption> DisambiguationOptions { get; private set;}


    }
}