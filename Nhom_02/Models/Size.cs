
using System.ComponentModel;

namespace Nhom_02.Models
{
    public class Size
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        // Navigation reference property cho khóa ngoại đến Products
        [DisplayName("Hóa đơn")]
        public Product Product { get; set; }

        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
