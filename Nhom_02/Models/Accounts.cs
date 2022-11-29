using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Nhom_02.Models
{
    public class Accounts
    {
        public int ID { get; set; }
        [DisplayName("Tên Đăng Nhập")]

        public string Username { get; set; }

        [DisplayName("Mật Khẩu")]
        public string Password { get; set; }

        [DisplayName("Số điện thoại")]
        [RegularExpression(@"0\d{9}", ErrorMessage = "SĐT không hợp lệ")]
        public int PhoneNumber { get; set; }

        [DisplayName("Họ và tên")]
        public string FullName { get; set; }

        [DisplayName("Loại tài khoản")]
        public int AccountTypeId { get; set; }

        [DisplayName("Ảnh đại diện")]
        public string Avatar { get; set; }

        [DisplayName("Trạng thái")]
        public bool Status { get; set; }

    }
}
