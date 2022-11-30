using System.ComponentModel;

namespace Nhom_02.Models
{
    public class Products
    {
        [DisplayName("Mã sản phẩm")]
        public int Id { get; set; }
        [DisplayName("Tên sản phẩm")]
        public string Name { get; set; }
        [DisplayName("Mô tả")]
        public string Description { get; set; }
        [DisplayName("Giá")]
        public int Price { get; set; }
        [DisplayName("Tồn kho")]
        public int Stock { get; set; }
        public int ProductTypeId { get; set; }
        [DisplayName("Trạng thái")]
        public bool Status { get; set; }

    }
}
