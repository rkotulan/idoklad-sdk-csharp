namespace IdokladSdk.Extensions
{
    internal static class StringExtensions
    {
        /// <summary>
        /// Removes quotation marks in whole string
        /// For example instead of =the "red"= returns =the red=
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string RemoveQuotationMarks(this string source)
        {
            source = source.Replace("\"", string.Empty);

            return source;
        }

        /// <summary>
        /// Returns whether string is null or empty
        /// </summary>
        public static bool IsNullOrEmpty(this string source)
        {
            return string.IsNullOrEmpty(source);
        }
    }
}
