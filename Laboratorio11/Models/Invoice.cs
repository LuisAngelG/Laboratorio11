namespace Laboratorio11.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }
        public float Total { get; set; }

    }
}
