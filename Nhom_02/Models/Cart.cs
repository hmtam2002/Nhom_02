using System.ComponentModel;

namespace Nhom_02.Models
{
    public class Cart
    {

        public int ProductId { get; set; }
        [DisplayName("Mã Tài Khoản")]
        public int AccountId { get; set; }
        [DisplayName("Số lượng")]
        public int Quantity { get; set; }
    }
}
