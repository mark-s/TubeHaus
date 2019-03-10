using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class SearchResponse
    {
        [JsonProperty("query")]
        public string Query { get; private set;}

        [JsonProperty("from")]
        public int From { get; private set;}

        [JsonProperty("page")]
        public int Page { get; private set;}

        [JsonProperty("pageSize")]
        public int PageSize { get; private set;}

        [JsonProperty("provider")]
        public string Provider { get; private set;}

        [JsonProperty("total")]
        public int Total { get; private set;}

        [JsonProperty("matches")]
        public ICollection<SearchMatch> Matches { get; private set;}

        [JsonProperty("maxScore")]
        public double MaxScore { get; private set;}


    }
}