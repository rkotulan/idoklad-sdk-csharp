using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.ApiModels
{
    [KnownType(typeof (BankAccount))]
    public class BankAccount : BankAccountPost
    {
        /// <summary>
        /// Informace o bance
        /// </summary>
        public Bank Bank { get; set; }

        /// <summary>
        /// Informace o měně
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// Datum poslední změny
        /// </summary>
        public DateTime DateLastChange { get; set; }

        /// <summary>
        /// Indikace výchozího bankovního účtu
        /// </summary>
        [ReadOnly(true)]
        public bool IsDefault { get; set; }
    }
}