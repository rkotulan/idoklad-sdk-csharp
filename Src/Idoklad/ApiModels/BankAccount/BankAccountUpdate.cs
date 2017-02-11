using System.ComponentModel.DataAnnotations;

namespace IdokladSdk.ApiModels
{
    public class BankAccountUpdate
    {
        /// <summary>
        /// Bank account number
        /// </summary>
        [StringLength(50)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Bank ID
        /// </summary>
        public int? BankId { get; set; }

        /// <summary>
        /// Currency ID
        /// </summary>
        public virtual int? CurrencyId { get; set; }

        /// <summary>
        /// International bank account number
        /// </summary>
        [StringLength(50)]
        public string Iban { get; set; }

        /// <summary>
        /// Name of the bank account
        /// </summary>
        [StringLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// Swift code
        /// </summary>
        [StringLength(11)]
        public string Swift { get; set; }
    }
}