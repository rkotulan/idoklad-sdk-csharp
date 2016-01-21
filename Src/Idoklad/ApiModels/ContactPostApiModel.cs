using System.ComponentModel.DataAnnotations;

namespace IdokladSdk.ApiModels
{
    public class ContactPost : ContactPut
    {
        /// <summary>
        /// Název kontaktu
        /// </summary>
        [StringLength(200)]
        [Required]
        public override string CompanyName { get; set; }

        [Required]
        public override int CountryId { get; set; }

        public new BankAccountPost DefaultBankAccount { get; set; }
    }
}