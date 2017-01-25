using System.ComponentModel.DataAnnotations;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.ApiModels
{
    public class BankAccountUpdate : ApiModel
    {
        /// <summary>
        /// Číslo účtu
        /// </summary>
        [StringLength(50)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Id banky
        /// </summary>
        public int? BankId { get; set; }

        /// <summary>
        /// Id měny
        /// </summary>
        public virtual int? CurrencyId { get; set; }

        /// <summary>
        /// Mezinárodní číslo bankovního účtu
        /// </summary>
        [StringLength(50)]
        public string Iban { get; set; }

        /// <summary>
        /// Název bankovního účtu
        /// </summary>
        [StringLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// Swift banky
        /// </summary>
        [StringLength(11)]
        public string Swift { get; set; }
    }
}