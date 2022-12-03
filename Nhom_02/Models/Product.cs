using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Nhom_02.Models
{
    public class Product
    {
        [DisplayName("Mã sản phẩm")]
        public int Id { get; set; }


        [DisplayName("Tên sản phẩm")]
        public string Name { get; set; }



        [DisplayName("Mô tả")]
        public string Description { get; set; }



        [DisplayName("Giá (VNĐ)")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        [DefaultValue(0)]
        public int Price { get; set; } = 0;



        [DisplayName("Tồn kho")]
        [DefaultValue(0)]
        public int Stock { get; set; } = 0;


        public int ProductTypeId { get; set; }
        // Navigation reference property cho khóa ngoại đến ProductType
        [DisplayName("Loại sản phẩm")]
        public ProductType ProductType { get; set; }



        [DisplayName("Trạng thái")]
        [DefaultValue(true)]
        public bool Status { get; set; } = true;




        // Collection reference property cho khóa ngoại từ Cart
        public List<Cart> Carts { get; set; }

        // Collection reference property cho khóa ngoại từ InvoiceDetail
        public List<InvoiceDetail> InvoiceDetails { get; set; }

        // Collection reference property cho khóa ngoại từ Size
        public List<Size> Sizes { get; set; }

        // Collection reference property cho khóa ngoại từ Color
        public List<Color> Colors { get; set; }


    }
}
