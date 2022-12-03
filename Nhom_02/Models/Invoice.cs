using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Nhom_02.Models
{
    public class Invoice
    {
        public int Id { get; set; }

        [DisplayName("Mã hóa đơn")]
        public int Code { get; set; }

        public int AccountId { get; set; }
        // Navigation reference property cho khóa ngoại đến Account 
        [DisplayName("Khách hàng")]
        public Account Account { get; set; }

        [DisplayName("Ngày lập hóa đơn")]
        [DataType(DataType.DateTime)]
        public DateTime IssuedDate { get; set; } = DateTime.Now;


        [DisplayName("Địa chỉ giao hàng")]
        public string ShippingAddress { get; set; }


        [DisplayName("Số điện thoại giao hàng")]
        public int ShippingPhone { get; set; }


        [DisplayName("Tổng tiền")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        [DefaultValue(0)]
        public int Total { get; set; }


        [DisplayName("Trạng thái")]
        public bool Status { get; set; }



        // Collection reference property cho khóa ngoại từ InvoiceDetail
        public List<InvoiceDetail> InvoiceDetails { get; set; }


    }
}
