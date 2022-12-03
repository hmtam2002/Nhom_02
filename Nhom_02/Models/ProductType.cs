using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Nhom_02.Models
{
    public class ProductType
    {
        public int Id { get; set; }        



        [DisplayName("Loại sản phẩm")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public string Name { get; set; }



        [DefaultValue(true)]
        [DisplayName("Trạng thái")]
        public bool Status { get; set; } = true;

        // Collection reference property cho khóa ngoại từ Product
        public List<Product> Products { get; set; }


    }
}
