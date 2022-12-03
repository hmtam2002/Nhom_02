using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Nhom_02.Models
{
    public class Color
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        // Collection reference property cho khóa ngoại từ Product
        public Product Products { get; set; }



        [DisplayName("Màu sắc")]
        public string ColorName { get; set; }


        [DisplayName("Trạng thái")]
        public bool Status { get; set; } = true;



        // Collection reference property cho khóa ngoại từ Image
        public List<Image> Images { get; set; }

    }
}
