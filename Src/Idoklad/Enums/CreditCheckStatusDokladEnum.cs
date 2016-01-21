using System.Runtime.Serialization;

namespace IdokladSdk.Enums
{
    [DataContract]
    public enum CreditCheckStatusDokladEnum
    {
        /// <summary>
        /// Grey - nenalezeno
        /// </summary>
        [EnumMember(Value = "0")]
        NotFound = 0,

        /// <summary>
        /// Green - prověřeno Ok
        /// </summary>
        [EnumMember(Value = "1")]
        Ok = 1,

        /// <summary>
        /// Yellow - prověřeno s výhradou
        /// </summary>
        [EnumMember(Value = "2")]
        OkWithWarnings = 2,

        /// <summary>
        /// Red - prověřeno s rizikem
        /// </summary>
        [EnumMember(Value = "3")]
        Risk = 3,

        /// <summary>
        /// Grey - Neprověřeno
        /// </summary>
        [EnumMember(Value = "4")]
        NoVerified = 4
    }
}