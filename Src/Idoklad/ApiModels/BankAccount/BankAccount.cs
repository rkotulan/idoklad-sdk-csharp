using System;
using System.Runtime.Serialization;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.ApiModels
{
    [KnownType(typeof (BankAccount))]
    public class BankAccount : BankAccountCreate, IApiModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Information about bank
        /// </summary>
        public Bank Bank { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// Date of last change
        /// </summary>
        public DateTime DateLastChange { get; set; }

        /// <summary>
        /// Indication for bank account (is default)
        /// </summary>
        public bool IsDefault { get; set; }
    }
}