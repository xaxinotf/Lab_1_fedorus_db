namespace Lab_1_fedorus_db.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}
