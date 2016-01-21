using System.Collections.Generic;

namespace IdokladSdk
{
    /// <summary>
    /// Validation message with member names
    /// </summary>
    public class ValidationMessage
    {
        /// <summary>
        /// Explained validation message based on data annotations
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Collection of affected members
        /// </summary>
        public IEnumerable<string> MemberNames { get; set; }
    }
}
