using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;
using IdokladSdk.ValidationAttributes;

namespace IdokladSdk.ApiModels
{
    public class ProformaInvoiceCreate : ApiModel
    {
        /// <summary>
        /// Responsibility for handlig of electronic records of sales
        /// </summary>
        [ValidEnumValue]
        public EetResponsibilityEnum EetResponsibility { get; set; }

        /// <summary>
        /// Flag indicating whether the sales receipt is registered in EET.
        /// </summary>
        public bool IsEet { get; set; }

        /// <summary>
        /// Záloha je daňový pohyb
        /// </summary>
        public bool IsProformaTaxed { get; set; }

        /// <summary>
        /// Položky faktury vydané
        /// </summary>
        [Required]
        [MinCollectionLength(1)]
        public IEnumerable<IssuedInvoiceItemWrite> ProformaInvoiceItems { get; set; }

        /// <summary>
        /// POS equipment id.
        /// </summary>
        public int? SalesPosEquipmentId { get; set; }

        /// <summary>
        /// Číslo účtu
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Bank Id from bank list
        /// </summary> 
        public int BankId { get; set; }

        /// <summary>
        /// Název banky
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// Kód banky
        /// </summary>
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
        public string Iban { get; set; }

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
        ///  Poznámka k dokumentu
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Číslo objednávky
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// Id způsobu úhrady
        /// </summary>
        public int PaymentOptionId { get; set; }

        /// <summary>
        /// Id odběratele
        /// </summary>
        public int PurchaserId { get; set; }

        /// <summary>
        /// Report color - in HTML fromat
        /// </summary>
        public string ReportColorValue { get; set; }

        /// <summary>
        /// Swift banky
        /// </summary>
        public string Swift { get; set; }

        /// <summary>
        /// Variabilní symbol
        /// </summary>
        public string VariableSymbol { get; set; }
    }
}