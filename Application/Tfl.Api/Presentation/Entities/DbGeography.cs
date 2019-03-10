using Newtonsoft.Json;
using Tfl.Api.RequestModels;

namespace Tfl.Api.Presentation.Entities
{
    public class DbGeography
    {
        [JsonProperty("geography")]
        public DbGeographyWellKnownValue Geography { get; private set;}


    }
}