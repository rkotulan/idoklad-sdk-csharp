using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.ApiModels
{
    public class DocumentAddress : ApiModel
    {
        [StringLength(50)]
        public string AccountNumber { get; set; }

        [StringLength(100)]
        public string Bank { get; set; }

        [StringLength(4)]
        public string BankNumberCode { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(100)]
        public string Country { get; set; }

        public int? CountryId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateLastChange { get; set; }

        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Firstname { get; set; }

        [StringLength(50)]
        public string Iban { get; set; }

        [StringLength(20)]
        public string IdentificationNumber { get; set; }

        [StringLength(20)]
        public string Mobile { get; set; }

        [StringLength(200)]
        public string NickName { get; set; }

        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [StringLength(11)]
        public string PostalCode { get; set; }

        [StringLength(100)]
        public string Street { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(11)]
        public string Swift { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(20)]
        public string VatIdentificationNumber { get; set; }

        [StringLength(20)]
        public string VatIdentificationNumberSk { get; set; }

        [StringLength(50)]
        public string Www { get; set; }
    }
}