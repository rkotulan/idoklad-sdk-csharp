using System.ComponentModel.DataAnnotations;

namespace IdokladSdk.ApiModels
{
    public class BankAccountPost : BankAccountPut
    {
        /// <summary>
        /// Id měny
        /// </summary>
        [Required]
        public new int CurrencyId { get; set; }
    }
}