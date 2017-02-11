namespace IdokladSdk.ApiFilters
{
    public enum FilterOperator
    {
        /// <summary>
        /// Lower than
        /// </summary>
        Lt = 0,

        /// <summary>
        /// Lower then or equal
        /// </summary>
        Lte = 1,

        /// <summary>
        /// Greather than
        /// </summary>
        Gt = 2,

        /// <summary>
        /// Greather than or equal
        /// </summary>
        Gte = 3,

        /// <summary>
        /// Equal
        /// </summary>
        Eq = 4,

        /// <summary>
        /// Not equal
        /// </summary>
        Neq = 5,

        /// <summary>
        /// Contains
        /// </summary>
        Ct = 6,

        /// <summary>
        /// Not contains
        /// </summary>
        Nct = 7,
    }
}
