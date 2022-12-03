using System.ComponentModel;

namespace Nhom_02.Models
{
    public class Image
    {
        public int Id { get; set; }

        public int ColorId { get; set; }
        // Collection reference property cho khóa ngoại từ Product
        public Color Color { get; set; }


        [DisplayName("Tên Ảnh")]
        public string Name { get; set; }
    }
}
