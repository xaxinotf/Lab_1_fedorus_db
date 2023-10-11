namespace Lab_1_fedorus_db.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address Address { get; set; }  // One-to-One relationship with Address
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
