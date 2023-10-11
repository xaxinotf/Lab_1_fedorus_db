namespace Lab_1_fedorus_db.Models
{
    public class SalesRecord
    {
        public int SalesRecordId { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public DateTime DateOfSale { get; set; }
        public int CopiesSold { get; set; }
    }
}
