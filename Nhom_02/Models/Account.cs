using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Nhom_02.Models
{
    public class Account
    {
        public int Id { get; set; }


        [DisplayName("Tên Đăng Nhập")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "{0} từ 6-20 kí tự")]
        public string Username { get; set; }


        [DisplayName("Mật Khẩu")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "{0} từ 6-20 kí tự")]
        public string Password { get; set; }


        [DisplayName("Email")]
        [EmailAddress(ErrorMessage = "{0} không hợp lệ")]
        public string Email { get; set; }


        [DisplayName("Số điện thoại")]
        [RegularExpression(@"0\d{9}", ErrorMessage = "SĐT không hợp lệ")]
        public string Phone { get; set; }


        [DisplayName("Họ và tên")]
        public string FullName { get; set; }


        [DisplayName("Loại tài khoản")]
        public int AccountTypeId { get; set; }
        public AccountType AccountType { get; set; }


        [DisplayName("Ảnh đại diện")]
        public string Avatar { get; set; }


        [DisplayName("Trạng thái")]
        [DefaultValue(true)]
        public bool Status { get; set; } = true;

        // Collection reference property cho khóa ngoại từ Invoice
        public List<Invoice> Invoices { get; set; }

        // Collection reference property cho khóa ngoại từ Cart
        public List<Cart> Carts { get; set; }

        // Collection reference property cho khóa ngoại từ Address
        public List<Address> Addresses  { get; set; }

    }
}
