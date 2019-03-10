using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.Fares
{
    public class RecommendationResponse
    {
        [JsonProperty("recommendations")]
        public ICollection<Recommendation> Recommendations { get; private set;}


    }
}