using System.ComponentModel;

namespace Nhom_02.Models
{
    public class Address
    {
        public int AccountId { get; set; }
        [DisplayName("Địa chỉ")]
        public string Place { get; set; }
    }
}
