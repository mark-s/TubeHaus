using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class RoadProject
    {
        [JsonProperty("projectId")]
        public string ProjectId { get; private set;}

        [JsonProperty("schemeName")]
        public string SchemeName { get; private set;}

        [JsonProperty("projectName")]
        public string ProjectName { get; private set;}

        [JsonProperty("projectDescription")]
        public string ProjectDescription { get; private set;}

        [JsonProperty("projectPageUrl")]
        public string ProjectPageUrl { get; private set;}

        [JsonProperty("consultationPageUrl")]
        public string ConsultationPageUrl { get; private set;}

        [JsonProperty("consultationStartDate")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset ConsultationStartDate { get; private set;}

        [JsonProperty("consultationEndDate")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset ConsultationEndDate { get; private set;}

        [JsonProperty("constructionStartDate")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset ConstructionStartDate { get; private set;}

        [JsonProperty("constructionEndDate")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset ConstructionEndDate { get; private set;}

        [JsonProperty("boroughsBenefited")]
        public ICollection<string> BoroughsBenefited { get; private set;}

        [JsonProperty("cycleSuperhighwayId")]
        public string CycleSuperhighwayId { get; private set;}

        [JsonProperty("phase")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RoadProjectPhase Phase { get; private set;}

        [JsonProperty("contactName")]
        public string ContactName { get; private set;}

        [JsonProperty("contactEmail")]
        public string ContactEmail { get; private set;}

        [JsonProperty("externalPageUrl")]
        public string ExternalPageUrl { get; private set;}

        [JsonProperty("projectSummaryPageUrl")]
        public string ProjectSummaryPageUrl { get; private set;}


    }
}