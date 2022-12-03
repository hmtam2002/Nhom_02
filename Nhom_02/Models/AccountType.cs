using System.ComponentModel;

namespace Nhom_02.Models
{
    public class AccountType
    {

        public int Id { get; set; }


        [DisplayName("Loại Tài Khoản ")]
        public string Name { get; set; }


        [DisplayName("Trạng thái")]
        public bool Status { get; set; } = true;


        // Collection reference property cho khóa ngoại từ Account
        public List<Account> Accounts { get;set; }
    }
}
