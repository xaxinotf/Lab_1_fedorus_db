namespace Lab_1_fedorus_db.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public Address Location { get; set; }
        public ICollection<SupplyRecord> SupplyRecords { get; set; } = new List<SupplyRecord>();
    }
}
