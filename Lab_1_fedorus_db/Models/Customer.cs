namespace Lab_1_fedorus_db.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public Address ShippingAddress { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
