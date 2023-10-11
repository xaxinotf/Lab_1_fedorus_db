namespace Lab_1_fedorus_db.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public string ReviewText { get; set; }
        public int Rating { get; set; }  // Out of 5, for example
    }
}
