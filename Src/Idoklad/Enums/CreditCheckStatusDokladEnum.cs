namespace IdokladSdk.Enums
{
    public enum CreditCheckStatusDokladEnum
    {
        /// <summary>
        /// Grey - nenalezeno
        /// </summary>
        NotFound = 0,

        /// <summary>
        /// Green - prověřeno Ok
        /// </summary>
        Ok = 1,

        /// <summary>
        /// Yellow - prověřeno s výhradou
        /// </summary>
        OkWithWarnings = 2,

        /// <summary>
        /// Red - prověřeno s rizikem
        /// </summary>
        Risk = 3,

        /// <summary>
        /// Grey - Neprověřeno
        /// </summary>
        NoVerified = 4
    }
}