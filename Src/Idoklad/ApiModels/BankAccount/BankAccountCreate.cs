using System.ComponentModel.DataAnnotations;

namespace IdokladSdk.ApiModels
{
    public class BankAccountCreate : BankAccountUpdate
    {
        /// <summary>
        /// Id měny
        /// </summary>
        [Required]
        public new int CurrencyId { get; set; }
    }
}