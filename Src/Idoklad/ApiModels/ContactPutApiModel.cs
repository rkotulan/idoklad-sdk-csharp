using System.ComponentModel.DataAnnotations;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.ApiModels
{
    public class ContactPut : ApiModel
    {
        /// <summary>
        /// Město kontaktu
        /// </summary>
        [StringLength(50)]
        public string City { get; set; }

        /// <summary>
        /// Název kontaktu
        /// </summary>
        [StringLength(200)]
        public virtual string CompanyName { get; set; }

        public virtual int CountryId { get; set; }

        public virtual BankAccountPut DefaultBankAccount { get; set; }

        public decimal? DiscountPercentage { get; set; }

        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Firstname { get; set; }

        /// <summary>
        /// IČ/IČO kontaktu
        /// </summary>
        [StringLength(20)]
        public string IdentificationNumber { get; set; }

        /// <summary>
        /// Zasílání upomínek
        /// </summary>
        public bool? IsSendReminder { get; set; }

        [StringLength(20)]
        public string Mobile { get; set; }

        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        /// <summary>
        /// PSČ kontaktu
        /// </summary>
        [StringLength(11)]
        public string PostalCode { get; set; }

        [StringLength(100)]
        public string Street { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        /// <summary>
        /// DIČ/IČ DPH kontaktu
        /// </summary>
        [StringLength(20)]
        public string VatIdentificationNumber { get; set; }

        /// <summary>
        /// DIČ kontaktu
        /// </summary>
        [StringLength(20)]
        public string VatIdentificationNumberSk { get; set; }

        [StringLength(50)]
        public string Www { get; set; }
    }
}