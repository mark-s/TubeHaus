using System.Runtime.Serialization;

namespace Tfl.Api.RequestModels
{
    /// <summary>The direction of travel.</summary>
    
    public enum TravelTimeOverlayDirection
    {
        [EnumMember(Value = "Average")]
        Average = 0,

        [EnumMember(Value = "From")]
        From = 1,

        [EnumMember(Value = "To")]
        To = 2,

    }
}