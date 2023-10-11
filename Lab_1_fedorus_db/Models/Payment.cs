namespace Lab_1_fedorus_db.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public double Amount { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
