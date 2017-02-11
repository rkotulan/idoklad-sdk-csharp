using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;

namespace IdokladSdk.ApiModels
{
    [KnownType(typeof (Contact))]
    public class Contact : ContactCreate, IApiModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Identification of the contact for Money software
        /// </summary>
        public Guid AddressIdg { get; set; }

        public CreditCheckStatusDokladEnum CreditCheck { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateLastChange { get; set; }

        /// <summary>
        /// Výchozí bankovní účet
        /// </summary>
        public new BankAccount DefaultBankAccount { get; set; }
    }
}