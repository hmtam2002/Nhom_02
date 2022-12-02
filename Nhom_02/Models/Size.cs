using System.ComponentModel;

namespace Nhom_02.Models
{
    public class Size
    {
        public int ProductIđ { get; set; }
        // Navigation reference property cho khóa ngoại đến Product
        [DisplayName("Sản phẩm")]
        public Product Product { get; set; }



        [DisplayName("Size")]
        public string SizeName { get; set; }

    }
}
