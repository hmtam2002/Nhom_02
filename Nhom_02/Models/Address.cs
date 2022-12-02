using System.ComponentModel;

namespace Nhom_02.Models
{
    public class Address
    {
        public int AccountId { get; set; }
        // Navigation reference property cho khóa ngoại đến Account
        [DisplayName("Khách hàng")]
        public Account  Account { get; set; }



        [DisplayName("Địa chỉ")]
        public string AddressName { get; set; };
    }
}
