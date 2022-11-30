using System.ComponentModel;

namespace Nhom_02.Models
{
    public class Invoices
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public int AccountId { get; set; }
        public int IssuedDate { get; set; }
        [DisplayName("Địa chỉ giao hàng")]
        public string ShippingAddress { get; set; }
        [DisplayName("Số điện thoại khách nhận")]
        public int ShippingPhone { get; set; }
        [DisplayName("Tổng tiền")]
        public int Total { get; set; }
        [DisplayName("Trạng thái")]
        public bool Status { get; set; }

    }
}
