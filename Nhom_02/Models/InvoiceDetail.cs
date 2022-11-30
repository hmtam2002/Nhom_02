using System.ComponentModel;

namespace Nhom_02.Models
{
    public class InvoiceDetail
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        [DisplayName("Số lượng")]
        public int Quantity { get; set; }

        public int UnitPrice { get; set; }

    }
}
