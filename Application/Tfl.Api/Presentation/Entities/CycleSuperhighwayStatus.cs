using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
    public enum CycleSuperhighwayStatus
    {
        [EnumMember(Value = "Unknown")]
        Unknown = 0,

        [EnumMember(Value = "All")]
        All = 1,

        [EnumMember(Value = "Existing")]
        Existing = 2,

        [EnumMember(Value = "Proposed")]
        Proposed = 3,

    }
}