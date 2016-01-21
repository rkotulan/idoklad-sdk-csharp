using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using IdokladSdk.Enums;

namespace IdokladSdk.ApiModels
{
    [KnownType(typeof (Contact))]
    public class Contact : ContactCreate
    {
        /// <summary>
        /// Identifikace kontaktu v rámci systému Money
        /// </summary>
        /// <summary xml:lang="en">
        /// Identification of the contact for Money software
        /// </summary>
        [ReadOnly(true)]
        public Guid AddressIdg { get; set; }

        [ReadOnly(true)]
        public CreditCheckStatusDokladEnum CreditCheck { get; set; }

        [DataType(DataType.DateTime)]
        [ReadOnly(true)]
        public DateTime DateLastChange { get; set; }

        /// <summary>
        /// Výchozí bankovní účet
        /// </summary>
        [ReadOnly(true)]
        public new BankAccount DefaultBankAccount { get; set; }

        [ReadOnly(true)]
        public override int Id { get; set; }
    }
}