using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities.AccidentStats
{
    
    public class AccidentDetail
    {
        [JsonProperty("id")]
        public int Id { get; private set;}

        [JsonProperty("lat")]
        public double Lat { get; private set;}

        [JsonProperty("lon")]
        public double Lon { get; private set;}

        [JsonProperty("location")]
        public string Location { get; private set;}

        [JsonProperty("date")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset Date { get; private set;}

        [JsonProperty("severity")]
        public string Severity { get; private set;}

        [JsonProperty("borough")]
        public string Borough { get; private set;}

        [JsonProperty("casualties")]
        public ICollection<Casualty> Casualties { get; private set;}

        [JsonProperty("vehicles")]
        public ICollection<Vehicle> Vehicles { get; private set;}


    }
}