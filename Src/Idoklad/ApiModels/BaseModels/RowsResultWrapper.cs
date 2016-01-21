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
            this.Data = allItems;
            this.TotalItems = count;
            this.TotalPages = (int)Math.Ceiling((double)this.TotalItems / pageSize);
        }

        /// <summary>
        /// Stránka se seznamem dat
        /// </summary>
        public List<TApiModel> Data { get; set; }

        /// <summary>
        /// Celkový počet záznamu
        /// </summary>
        public int TotalItems { get; set; }

        /// <summary>
        /// Počet stránek
        /// </summary>
        public int TotalPages { get; set; }
    }
}
