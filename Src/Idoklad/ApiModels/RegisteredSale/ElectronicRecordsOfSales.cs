using IdokladSdk.Enums;

namespace IdokladSdk.ApiModels
{
    public class ElectronicRecordsOfSales
    {
        //public ElectronicRecordsOfSalesStatusEnum? EetStatus { get; set; }

        public bool IsEet { get; set; }

        public RegisteredSaleInformation RegisteredSale { get; set; }

        public EetResponsibilityEnum EetResponsibility { get; set; }
    }
}