using System;

namespace IdokladSdk.ApiFilters
{
    public class ChangeFilter : Paging, IApiFilter
    {
        public DateTime LastCheck { get; set; }

        /// <summary>
        /// Default Change filter (last year)
        /// </summary>
        public ChangeFilter()
        {
            this.LastCheck = DateTime.UtcNow.AddYears(-1);
        }

        /// <summary>
        /// Change filter from requested start date
        /// </summary>
        public ChangeFilter(DateTime lastCheck)
        {
            this.LastCheck = lastCheck;
        }
    }
}
