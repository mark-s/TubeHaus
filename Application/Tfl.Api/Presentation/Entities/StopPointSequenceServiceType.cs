using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
    public enum StopPointSequenceServiceType
    {
        [EnumMember(Value = "Regular")]
        Regular = 0,

        [EnumMember(Value = "Night")]
        Night = 1,

    }
}