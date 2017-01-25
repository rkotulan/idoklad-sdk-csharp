using System.Runtime.Serialization;
using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.ApiModels
{
    [KnownType(typeof(CashRegisterExpand))]
    public class CashRegisterExpand : CashRegister
    {
        public Currency Currency { get; set; }
    }
}