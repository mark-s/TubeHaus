using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    /// <summary>Bike point occupancy</summary>
    
    public class BikePointOccupancy
    {
        /// <summary>Id of the bike point such as BikePoints_1</summary>
        [JsonProperty("id")]
        public string Id { get; private set;}

        /// <summary>Name / Common name of the bike point</summary>
        [JsonProperty("name")]
        public string Name { get; private set;}

        /// <summary>Total bike counts</summary>
        [JsonProperty("bikesCount")]
        public int BikesCount { get; private set;}

        /// <summary>Empty docks</summary>
        [JsonProperty("emptyDocks")]
        public int EmptyDocks { get; private set;}

        /// <summary>Total docks available</summary>
        [JsonProperty("totalDocks")]
        public int TotalDocks { get; private set;}


    }
}