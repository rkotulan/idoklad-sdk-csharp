using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;

namespace IdokladSdk.ApiModels.ReceivedInvoice
{
    public class ReceivedInvoice : ApiModel
    {
        /// <summary>
        /// Id měny
        /// </summary>
        public int CurrencyId { get; set; }

        /// <summary>
        /// Datum vytvoření
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Datum poslední změny
        /// </summary>
        public DateTime DateLastChange { get; set; }

        /// <summary>
        /// Datum účetního připadu
        /// </summary>
        public DateTime DateOfAccountingEvent { get; set; }

        /// <summary>
        /// Datum vystavení dokladu
        /// </summary>
        public DateTime DateOfIssue { get; set; }

        /// <summary>
        /// Datum splatnosti
        /// </summary>
        public DateTime DateOfMaturity { get; set; }

        /// <summary>
        /// Datum úhrady
        /// </summary>
        public DateTime DateOfPayment { get; set; }

        /// <summary>
        /// Datum přijetí dokladu
        /// </summary>
        public DateTime DateOfReceiving { get; set; }

        /// <summary>
        /// Datum uskutečnění zdanitelného plnění
        /// </summary>
        public DateTime DateOfTaxing { get; set; }

        /// <summary>
        /// Popis dokladu
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Číslo dokladu
        /// </summary>
        [StringLength(10)]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Pořadové číslo dokladu
        /// </summary>
        public int DocumentSerialNumber { get; set; }

        /// <summary>
        /// Kurz měny
        /// </summary>
        public decimal ExchangeRate { get; set; }

        /// <summary>
        /// Množství měny pro kurz
        /// </summary>
        public decimal ExchangeRateAmount { get; set; }

        /// <summary>
        /// Export to another accounting software indication. (It is recommended to use only one external accounting software
        /// beside iDoklad.)
        /// </summary>
        public ExportedStateEnum Exported { get; set; }

        /// <summary>
        /// Příznak Odesláno účetní
        /// </summary>
        public bool IsSentToAccountant { get; set; }

        /// <summary>
        /// Položky faktury přijaté
        /// </summary>
        public List<ReceivedInvoiceItem> Items { get; set; }

        /// <summary>
        /// Id kontaktních údajů odběratele
        /// </summary>
        public int MyCompanyDocumentAddressId { get; set; }

        /// <summary>
        /// Poznámka k dokumentu
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Číslo objednávky
        /// </summary>
        [StringLength(20)]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Id způsobu úhrady
        /// </summary>
        public int? PaymentOptionId { get; set; }

        /// <summary>
        /// Stav zaplacení faktury
        /// </summary>
        public PaymentStatusEnum PaymentStatus { get; set; }

        /// <summary>
        /// Document number of the original document
        /// </summary>
        [StringLength(20)]
        public string ReceivedDocumentNumber { get; set; }

        /// <summary>
        /// Id kontaktních údajů dodavatele
        /// </summary>
        public int SupplierDocumentAddressId { get; set; }

        /// <summary>
        /// Id dodavatele
        /// </summary>
        public int SupplierId { get; set; }

        /// <summary>
        /// Celkově uhrazená částka
        /// </summary>
        public decimal TotalPaid { get; set; }

        /// <summary>
        /// Celkově uhrazená částka v domácí měně
        /// </summary>
        public decimal TotalPaidHc { get; set; }

        /// <summary>
        /// Celkové DPH
        /// </summary>
        public decimal TotalVat { get; set; }

        /// <summary>
        /// Celkové DPH v domácí měně
        /// </summary>
        public decimal TotalVatHc { get; set; }

        /// <summary>
        /// Celková cena s DPH
        /// </summary>
        public decimal TotalWithVat { get; set; }

        /// <summary>
        /// Celková cena s DPH v domácí měně
        /// </summary>
        public decimal TotalWithVatHc { get; set; }

        /// <summary>
        /// Celková cena bez DPH
        /// </summary>
        public decimal TotalWithoutVat { get; set; }

        /// <summary>
        /// Celková cena bez DPH v domácí měně
        /// </summary>
        public decimal TotalWithoutVatHc { get; set; }

        /// <summary>
        /// Variabilní symbol
        /// </summary>
        [StringLength(10)]
        public string VariableSymbol { get; set; }
    }
}