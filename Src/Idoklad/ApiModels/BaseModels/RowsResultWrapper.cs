using System;
using System.Collections.Generic;

namespace IdokladSdk.ApiModels.BaseModels
{
    public class RowsResultWrapper<TApiModel> where TApiModel : class, IApiModel
    {
        public RowsResultWrapper()
        {
        }

        public RowsResultWrapper(
            List<TApiModel> allItems,
            int pageSize,
            int count)
        {
            Data = allItems;
            TotalItems = count;
            TotalPages = (int)Math.Ceiling((double)TotalItems / pageSize);
        }

        /// <summary>
        /// Page with data
        /// </summary>
        public List<TApiModel> Data { get; set; }

        /// <summary>
        /// Total count of records
        /// </summary>
        public int TotalItems { get; set; }

        /// <summary>
        /// Total pages
        /// </summary>
        public int TotalPages { get; set; }
    }
}
