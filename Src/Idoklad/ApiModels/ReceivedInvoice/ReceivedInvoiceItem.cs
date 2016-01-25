using System;
using System.Runtime.Serialization;
using IdokladSdk.Enums;

namespace IdokladSdk.ApiModels.ReceivedInvoice
{
    /// <summary>
    /// Received invoice item.
    /// </summary>
    [KnownType(typeof (ReceivedInvoiceItem))]
    public class ReceivedInvoiceItem : ReceivedInvoiceItemUpdate
    {
        /// <summary>
        /// Datum vytvoření
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Datum poslední změny
        /// </summary>
        public DateTime DateLastChange { get; set; }

        /// <summary>
        /// Indicates if item has custom Vat value
        /// </summary>
        public bool IsCustomVat { get; set; }

        /// <summary>
        /// Typ položky
        /// </summary>
        public IssuedInvoiceItemTypeEnum ItemType { get; set; }

        /// <summary>
        /// Celková cena
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Celková cena s DPH
        /// </summary>
        public decimal PriceTotalWithVat { get; set; }

        /// <summary>
        /// Celková cena s DPH v domací měně
        /// </summary>
        public decimal PriceTotalWithVatHc { get; set; }

        /// <summary>
        /// Celková cena bez DPH
        /// </summary>
        public decimal PriceTotalWithoutVat { get; set; }

        /// <summary>
        /// Celková cena bez DPH v domací měně
        /// </summary>
        public decimal PriceTotalWithoutVatHc { get; set; }

        /// <summary>
        /// Celková cena za jednotku v domací měně
        /// </summary>
        public decimal PriceUnitHc { get; set; }

        /// <summary>
        /// hodnota DPH
        /// </summary>
        public decimal VatRate { get; set; }

        /// <summary>
        /// Celkové DPH
        /// </summary>
        public decimal VatTotal { get; set; }

        /// <summary>
        /// Celkové DPH v domací měně
        /// </summary>
        public decimal VatTotalHc { get; set; }
    }
}