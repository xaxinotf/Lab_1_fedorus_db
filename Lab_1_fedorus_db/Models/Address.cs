namespace Lab_1_fedorus_db.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int? AuthorId { get; set; }
        public Author Author { get; set; }
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int? SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }

}
