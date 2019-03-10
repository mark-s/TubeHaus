using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
    public enum VehicleMatchCompliance
    {
        [EnumMember(Value = "NotAvailable")]
        NotAvailable = 0,

        [EnumMember(Value = "NotCompliant")]
        NotCompliant = 1,

        [EnumMember(Value = "Compliant")]
        Compliant = 2,

        [EnumMember(Value = "Exempt")]
        Exempt = 3,

    }
}