using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class Place
    {
        /// <summary>A unique identifier.</summary>
        [JsonProperty("id")]
        public string Id { get; private set;}

        /// <summary>The unique location of this resource.</summary>
        [JsonProperty("url")]
        public string Url { get; private set;}

        /// <summary>A human readable name.</summary>
        [JsonProperty("commonName")]
        public string CommonName { get; private set;}

        /// <summary>The distance of the place from its search point, if this is the result
        ///             of a geographical search, otherwise zero.</summary>
        [JsonProperty("distance")]
        public double Distance { get; private set;}

        /// <summary>The type of Place. See /Place/Meta/placeTypes for possible values.</summary>
        [JsonProperty("placeType")]
        public string PlaceType { get; private set;}

        /// <summary>A bag of additional key/value pairs with extra information about this place.</summary>
        [JsonProperty("additionalProperties")]
        public ICollection<AdditionalProperties> AdditionalProperties { get; private set;}

        [JsonProperty("children")]
        public ICollection<Place> Children { get; private set;}

        [JsonProperty("childrenUrls")]
        public ICollection<string> ChildrenUrls { get; private set;}

        /// <summary>WGS84 latitude of the location.</summary>
        [JsonProperty("lat")]
        public double Lat { get; private set;}

        /// <summary>WGS84 longitude of the location.</summary>
        [JsonProperty("lon")]
        public double Lon { get; private set;}


    }
}