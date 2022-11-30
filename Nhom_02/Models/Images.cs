using System.ComponentModel;

namespace Nhom_02.Models
{
    public class Images
    {
        public int ColorId { get; set; }
        [DisplayName("Tên Ảnh")]
        public string Image { get; set; }
    }
}
