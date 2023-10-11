namespace Lab_1_fedorus_db.Models
{
    public class SupplyRecord
    {
        public int SupplyRecordId { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public DateTime SupplyDate { get; set; }
        public int CopiesSupplied { get; set; }
    }
}
