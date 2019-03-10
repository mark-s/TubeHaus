using System.Runtime.Serialization;

namespace Tfl.Api.RequestModels
{
    /// <summary>Does the time given relate to arrival or leaving time Possible options: "departing" | "arriving"</summary>
    
    public enum TimeIs
    {
        [EnumMember(Value = "Arriving")]
        Arriving = 0,

        [EnumMember(Value = "Departing")]
        Departing = 1,

    }
}