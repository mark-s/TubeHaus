using System.Runtime.Serialization;

namespace Tfl.Api.RequestModels
{
    /// <summary>Optional. The direction of travel. Can be inbound or outbound or all. If left blank, and destinationStopId is set, will default to all</summary>
    
    public enum Direction2
    {
        [EnumMember(Value = "inbound")]
        Inbound = 0,

        [EnumMember(Value = "outbound")]
        Outbound = 1,

        [EnumMember(Value = "all")]
        All = 2,

    }
}