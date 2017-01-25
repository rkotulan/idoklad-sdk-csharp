using System.Runtime.Serialization;

namespace IdokladSdk.Enums
{
    public enum PaymentStatusEnum
    {
        Unpaid = 0,

        Paid = 1,

        PartialPaid = 2,

        Overpaid = 3
    }
}