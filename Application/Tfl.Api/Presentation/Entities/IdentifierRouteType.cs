using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
    public enum IdentifierRouteType
    {
        [EnumMember(Value = "Unknown")]
        Unknown = 0,

        [EnumMember(Value = "All")]
        All = 1,

        [EnumMember(Value = "CycleSuperHighways")]
        CycleSuperHighways = 2,

        [EnumMember(Value = "Quietways")]
        Quietways = 3,

        [EnumMember(Value = "MiniHollands")]
        MiniHollands = 4,

        [EnumMember(Value = "CentralLondonGrid")]
        CentralLondonGrid = 5,

        [EnumMember(Value = "RoadsProject")]
        RoadsProject = 6,

    }
}