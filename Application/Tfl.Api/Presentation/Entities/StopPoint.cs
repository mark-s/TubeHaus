using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tfl.Api.Presentation.Entities
{
    public class StopPoint
    {
        [JsonProperty("naptanId")]
        public string NaptanId { get;  private set;}

        [JsonProperty("platformName")]
        public string PlatformName { get;  private set;}

        /// <summary>The indicator of the stop point e.g. "Stop K"</summary>
        [JsonProperty("indicator")]
        public string Indicator { get;  private set;}

        /// <summary>The stop letter, if it could be cleansed from the Indicator e.g. "K"</summary>
        [JsonProperty("stopLetter")]
        public string StopLetter { get;  private set;}

        [JsonProperty("modes")]
        public ICollection<string> Modes { get;  private set;}

        [JsonProperty("icsCode")]
        public string IcsCode { get;  private set;}

        [JsonProperty("smsCode")]
        public string SmsCode { get;  private set;}

        [JsonProperty("stopType")]
        public string StopType { get;  private set;}

        [JsonProperty("stationNaptan")]
        public string StationNaptan { get;  private set;}

        [JsonProperty("accessibilitySummary")]
        public string AccessibilitySummary { get;  private set;}

        [JsonProperty("hubNaptanCode")]
        public string HubNaptanCode { get;  private set;}

        [JsonProperty("lines")]
        public ICollection<Identifier> Lines { get;  private set;}

        [JsonProperty("lineGroup")]
        public ICollection<LineGroup> LineGroup { get;  private set;}

        [JsonProperty("lineModeGroups")]
        public ICollection<LineModeGroup> LineModeGroups { get;  private set;}

        [JsonProperty("fullName")]
        public string FullName { get;  private set;}

        [JsonProperty("naptanMode")]
        public string NaptanMode { get;  private set;}

        [JsonProperty("status")]
        public bool Status { get;  private set;}

        /// <summary>A unique identifier.</summary>
        [JsonProperty("id")]
        public string Id { get;  private set;}

        /// <summary>The unique location of this resource.</summary>
        [JsonProperty("url")]
        public string Url { get;  private set;}

        /// <summary>A human readable name.</summary>
        [JsonProperty("commonName")]
        public string CommonName { get;  private set;}

        /// <summary>The distance of the place from its search point, if this is the result<br />
        ///             of a geographical search, otherwise zero.</summary>
        [JsonProperty("distance")]
        public double Distance { get;  private set;}

        /// <summary>The type of Place. See /Place/Meta/placeTypes for possible values.</summary>
        [JsonProperty("placeType")]
        public string PlaceType { get;  private set;}

        /// <summary>A bag of additional key/value pairs with extra information about this place.</summary>
        [JsonProperty("additionalProperties")]
        public ICollection<AdditionalProperties> AdditionalProperties { get;  private set;}

        [JsonProperty("children")]
        public ICollection<Place> Children { get;  private set;}

        [JsonProperty("childrenUrls")]
        public ICollection<string> ChildrenUrls { get;  private set;}

        /// <summary>WGS84 latitude of the location.</summary>
        [JsonProperty("lat")]
        public double Lat { get;  private set;}

        /// <summary>WGS84 longitude of the location.</summary>
        [JsonProperty("lon")]
        public double Lon { get;  private set;}


    }
}