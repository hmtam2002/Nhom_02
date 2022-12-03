using System.ComponentModel;

namespace Nhom_02.Models
{
    public class Address
    {
        public int Id { get; set; }

        public int AccountId { get; set; }
        public Account Account { get; set; }


        [DisplayName("Địa chỉ")]
        public string Name { get; set; }
    }
}
