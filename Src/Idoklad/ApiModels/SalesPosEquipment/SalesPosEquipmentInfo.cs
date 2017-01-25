namespace IdokladSdk.ApiModels
{
    public class SalesPosEquipmentInfo
    {
        /// <summary>
        /// Sales office designation
        /// </summary>
        public string Designation { get; set; }

        /// <summary>
        /// POS equipment id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// POS equipment name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Information about the associated numeric sequence.
        /// </summary>
        public NumericSequence NumericSequence { get; set; }

        /// <summary>
        /// Sales office Id.
        /// </summary>
        public int? SalesOfficeId { get; set; }
    }
}