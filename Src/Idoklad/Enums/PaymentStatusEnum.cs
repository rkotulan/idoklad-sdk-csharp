using System.Runtime.Serialization;

namespace IdokladSdk.Enums
{
    [DataContract]
    public enum PaymentStatusEnum
    {
        [EnumMember(Value = "0")]
        Unpaid = 0,

        [EnumMember(Value = "1")]
        Paid = 1,

        [EnumMember(Value = "2")]
        PartialPaid = 2,

        [EnumMember(Value = "3")]
        Overpaid = 3
    }
}