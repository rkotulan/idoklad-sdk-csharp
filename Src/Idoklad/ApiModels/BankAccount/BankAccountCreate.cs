using System.ComponentModel.DataAnnotations;

namespace IdokladSdk.ApiModels
{
    public class BankAccountCreate : BankAccountUpdate
    {
        /// <summary>
        /// Currency ID
        /// </summary>
        [Required]
        public new int CurrencyId { get; set; }
    }
}