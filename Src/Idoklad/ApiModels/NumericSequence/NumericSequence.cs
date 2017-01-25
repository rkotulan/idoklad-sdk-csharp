using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdokladSdk.Enums;

namespace IdokladSdk.ApiModels
{
    public class NumericSequence
    {
        /// <summary>
        /// Number of last invoice. The next invoice will be saved with the number (LastInvoiceNumber + 1)
        /// </summary>
        public int LastInvoiceNumber { get; set; }

        /// <summary>
        /// Invoice number format (R = year, M = month, N = number)
        /// </summary>
        public string NumberFormat { get; set; }

        /// <summary>
        /// Flag indicating whether the numeric sequence is set as default. New documents without a sequence id specified will have the default sequence set
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// Name of the numeric sequence
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Year of the sequence's validity
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Document type
        /// </summary>
        public DocumentTypeEnum DocumentType { get; set; }
    }
}
