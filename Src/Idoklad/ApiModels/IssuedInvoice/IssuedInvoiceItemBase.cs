using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using IdokladSdk.Enums;

namespace IdokladSdk.ApiModels
{
    public class IssuedInvoiceItemBase : IssuedInvoiceItemWrite
    {
        [StringLength(20)]
        public string Code { get; set; }

        public DateTime DateLastChange { get; set; }

        /// <summary>
        /// Indikace, zda je položka zaokrouhlovací
        /// </summary>
        public bool IsRoundedItem { get; set; }

        /// <summary>
        /// Indikace, zda je položka daňový pohyb
        /// </summary>
        public bool IsTaxMovement { get; set; }

        /// <summary>
        /// Identifikace typu položky
        /// </summary>
        public IssuedInvoiceItemTypeEnum ItemType { get; set; }

        public decimal Price { get; set; }

        public decimal PriceTotalWithVat { get; set; }

        public decimal PriceTotalWithVatHc { get; set; }

        public decimal PriceTotalWithoutVat { get; set; }

        public decimal PriceTotalWithoutVatHc { get; set; }

        public decimal PriceUnitVat { get; set; }

        public decimal PriceUnitVatHc { get; set; }

        public decimal PriceUnitWithVat { get; set; }

        public decimal PriceUnitWithVatHc { get; set; }

        public decimal PriceUnitWithoutVat { get; set; }

        public decimal PriceUnitWithoutVatHc { get; set; }

        public decimal TotalPrice { get; set; }

        public decimal VatRate { get; set; }

        public decimal VatTotal { get; set; }

        public decimal VatTotalHc { get; set; }
    }
}