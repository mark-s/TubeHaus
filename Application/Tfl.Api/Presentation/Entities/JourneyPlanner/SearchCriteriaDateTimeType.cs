using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
    public enum SearchCriteriaDateTimeType
    {
        [EnumMember(Value = "Arriving")]
        Arriving = 0,

        [EnumMember(Value = "Departing")]
        Departing = 1,

    }
}