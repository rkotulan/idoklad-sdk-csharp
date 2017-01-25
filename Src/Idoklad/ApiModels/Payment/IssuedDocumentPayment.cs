using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdokladSdk.Enums;

namespace IdokladSdk.ApiModels
{
    public class IssuedDocumentPayment : Payment
    {
        public EetResponsibilityEnum EetResponsibility { get; set; }
        public EetStatusEnum EetStatus { get; set; }
        public bool IsEet { get; set; }
        public RegisteredSale RegisteredSale { get; set; }
    }
}
