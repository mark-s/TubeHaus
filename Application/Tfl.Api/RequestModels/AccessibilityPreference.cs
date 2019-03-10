using System.Runtime.Serialization;

namespace Tfl.Api.RequestModels
{
    public enum AccessibilityPreference
    {
        [EnumMember(Value = "NoRequirements")]
        NoRequirements = 0,

        [EnumMember(Value = "NoSolidStairs")]
        NoSolidStairs = 1,

        [EnumMember(Value = "NoEscalators")]
        NoEscalators = 2,

        [EnumMember(Value = "NoElevators")]
        NoElevators = 3,

        [EnumMember(Value = "StepFreeToVehicle")]
        StepFreeToVehicle = 4,

        [EnumMember(Value = "StepFreeToPlatform")]
        StepFreeToPlatform = 5,

    }
}