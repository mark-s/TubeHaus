using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    /// <summary>A paged response containing StopPoints</summary>
    
    public class StopPointsResponse
    {
        /// <summary>The centre latitude/longitude of this list of StopPoints</summary>
        [JsonProperty("centrePoint")]
        public ICollection<double> CentrePoint { get; private set;}

        /// <summary>Collection of stop points</summary>
        [JsonProperty("stopPoints")]
        public ICollection<StopPoint> StopPoints { get; private set;}

        /// <summary>The maximum size of the page in this response i.e. the maximum number of StopPoints</summary>
        [JsonProperty("pageSize")]
        public int PageSize { get; private set;}

        /// <summary>The total number of StopPoints available across all pages</summary>
        [JsonProperty("total")]
        public int Total { get; private set;}

        /// <summary>The index of this page</summary>
        [JsonProperty("page")]
        public int Page { get; private set;}


    }
}