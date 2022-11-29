namespace Nhom_02.Models
{
    public class Invoices
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public int AccountId { get; set; }
        public int IssuedDate  { get; set; }
        public string   ShippingAddress { get; set; }
        public int ShippingPhone { get; set; }
    }
}
