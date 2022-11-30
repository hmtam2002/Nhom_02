using System.ComponentModel;

namespace Nhom_02.Models
{
    public class Colors
    {
        public int Id { get; set; }
        [DisplayName("Màu sắc")]
        public string Color { get; set; }
        [DisplayName("Trạng thái")]
        public bool Status { get; set; }
    }
}
