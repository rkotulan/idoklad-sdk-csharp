using System.Collections.Generic;
using System.Runtime.Serialization;
using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.ApiModels
{
    [KnownType(typeof (ContactExpand))]
    public class ContactExpand : Contact
    {
        /// <summary>
        /// Seznam bankovních účtů kontaktu
        /// </summary>
        public IList<BankAccount> BankAccounts { get; set; }

        /// <summary>
        /// Informace o státu
        /// </summary>
        public Country Country { get; set; }
    }
}