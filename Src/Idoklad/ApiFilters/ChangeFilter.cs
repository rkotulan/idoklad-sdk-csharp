using System;

namespace IdokladSdk.ApiFilters
{
    public class ChangeFilter : ApiFilter, IApiFilter
    {
        public DateTime LastCheck { get; set; }

        /// <summary>
        /// Default Change filter (last year)
        /// </summary>
        public ChangeFilter()
        {
            LastCheck = DateTime.UtcNow.AddYears(-1);
        }

        /// <summary>
        /// Change filter from requested start date
        /// </summary>
        public ChangeFilter(DateTime lastCheck)
        {
            LastCheck = lastCheck;
        }
    }
}
