using System.Runtime.Serialization;
using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.ApiModels
{
    [KnownType(typeof(CashRegisterExpand))]
    public class CashRegisterExpand : CashRegister
    {
        /// <summary>
        /// Currency info
        /// </summary>
        public Currency Currency { get; set; }
    }
}