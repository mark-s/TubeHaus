using System.Collections.Generic;
using Newtonsoft.Json;
using Tfl.Api.Common;

namespace Tfl.Api.Presentation.Entities
{
    public class PlacePolygon
    {
        [JsonProperty("geoPoints")]
        public ICollection<GeoPoint> GeoPoints { get; private set;}

        [JsonProperty("commonName")]
        public string CommonName { get; private set;}


    }
}