using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IdokladSdk.ApiModels.ReceivedInvoice
{
    public class ReceivedInvoiceUpdate
    {
        /// <summary>
        /// Číslo účtu
        /// </summary>
        [StringLength(50)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Id banky z číselníku Bank
        /// </summary>
        public int? BankId { get; set; }

        /// <summary>
        /// Kód banky dodavatele
        /// </summary>
        [StringLength(4)]
        public string BankNumberCode { get; set; }

        /// <summary>
        /// Id měny
        /// </summary>
        public int? CurrencyId { get; set; }

        /// <summary>
        /// Datum vytvoření dokladu
        /// </summary>
        public DateTime? DateOfIssue { get; set; }

        /// <summary>
        /// Datum splatnosti
        /// </summary>
        public DateTime? DateOfMaturity { get; set; }

        /// <summary>
        /// Datum úhrady
        /// </summary>
        public DateTime? DateOfPayment { get; set; }

        /// <summary>
        /// Datum vytvoření dokladu
        /// </summary>
        public DateTime? DateOfReceiving { get; set; }

        /// <summary>
        /// DUZP - pouze pro plátce DPH
        /// </summary>
        public DateTime? DateOfTaxing { get; set; }

        /// <summary>
        /// Popis dokladu
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Pořadové číslo faktury
        /// </summary>
        public int? DocumentSerialNumber { get; set; }

        /// <summary>
        /// Číslo faktury
        /// </summary>
        [ReadOnly(true)]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Kurz měny
        /// </summary>
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// Množství měny pro kurz
        /// </summary>
        public decimal? ExchangeRateAmount { get; set; }

        /// <summary>
        /// Iban of the supplier
        /// </summary>
        [StringLength(50)]
        public string Iban { get; set; }

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
        /// Document number of the original document
        /// </summary>
        [StringLength(20)]
        public string ReceivedDocumentNumber { get; set; }

        /// <summary>
        /// Položky faktury přijaté
        /// </summary>
        public List<ReceivedInvoiceItemUpdate> ReceivedInvoiceItems { get; set; }

        /// <summary>
        /// Id dodavatele
        /// </summary>
        public int? SupplierId { get; set; }

        /// <summary>
        /// Swift of the supplier
        /// </summary>
        [StringLength(11)]
        public string Swift { get; set; }

        /// <summary>
        /// Variabilní symbol
        /// </summary>
        [StringLength(10)]
        public string VariableSymbol { get; set; }
    }
}