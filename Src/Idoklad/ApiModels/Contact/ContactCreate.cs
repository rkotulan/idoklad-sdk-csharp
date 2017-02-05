﻿using System.ComponentModel.DataAnnotations;

namespace IdokladSdk.ApiModels
{
    public class ContactCreate : ContactUpdate
    {
        /// <summary>
        /// Název kontaktu
        /// </summary>
        [StringLength(200)]
        [Required]
        public override string CompanyName { get; set; }

        [Required]
        public override int CountryId { get; set; }

        public new BankAccountCreate DefaultBankAccount { get; set; }

        /// <summary>
        /// Attribute for application of VAT based on payments
        /// </summary>
        public bool IsRegisteredForVatOnPay { get; set; }
    }
}