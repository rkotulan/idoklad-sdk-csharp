using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IdokladSdk.ApiModels.IssuedInvoice
{
    public class IssuedInvoiceCreate
    {
        /// <summary>
        /// Číslo účtu
        /// </summary>
        [StringLength(50)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Bank Id from bank list
        /// </summary>
        public int BankId { get; set; }

        /// <summary>
        /// Název banky
        /// </summary>
        [StringLength(100)]
        public string BankName { get; set; }

        /// <summary>
        /// Kód banky
        /// </summary>
        [StringLength(4)]
        public string BankNumberCode { get; set; }

        /// <summary>
        /// Id konstantního symbolu
        /// </summary>
        public int ConstantSymbolId { get; set; }

        /// <summary>
        /// Id měny
        /// </summary>
        public int CurrencyId { get; set; }

        /// <summary>
        /// Datum vytvoření dokladu
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
        /// DUZP - pouze pro plátce DPH
        /// </summary>
        public DateTime DateOfTaxing { get; set; }

        /// <summary>
        /// Popis dokladu
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Sleva dokladu
        /// </summary>
        public decimal DiscountPercentage { get; set; }

        /// <summary>
        /// Číslo faktury
        /// </summary>
        [StringLength(10)]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Pořadové číslo faktury
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
        /// Mezinárodní číslo bankovního účtu
        /// </summary>
        [StringLength(50)]
        public string Iban { get; set; }

        /// <summary>
        /// Položky faktury vydané
        /// </summary>
        [Required]
        public IEnumerable<IssuedInvoiceItemWrite> IssuedInvoiceItems { get; set; }

        /// <summary>
        /// Text před položkami faktury
        /// </summary>
        public string ItemsTextPrefix { get; set; }

        /// <summary>
        /// Text za položkami faktury
        /// </summary>
        public string ItemsTextSuffix { get; set; }

        /// <summary>
        /// Kód jazyka
        /// </summary>
        public string LanguageCode { get; set; }

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
        public int PaymentOptionId { get; set; }

        /// <summary>
        /// Id odběratele
        /// </summary>
        [Required]
        public int PurchaserId { get; set; }

        /// <summary>
        /// Report color - in HTML fromat
        /// </summary>
        public string ReportColorValue { get; set; }

        /// <summary>
        /// Swift banky
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