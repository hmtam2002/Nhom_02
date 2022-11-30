using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Nhom_02.Models
{
    public class Cart
    {
        [Key]
        public int ProductId { get; set; }
        [DisplayName("Mã Tài Khoản")]
        [Key]
        public int AccountId { get; set; }
        [DisplayName("Số lượng")]
        public int Quantity { get; set; }
    }
}
