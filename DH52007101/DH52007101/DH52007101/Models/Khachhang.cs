using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DH52007101.Models {
    public partial class Khachhang {
        public Khachhang() {
            Phieudathang = new HashSet<Phieudathang>();
        }
        [DisplayName("Mã khách hàng")]
        [Required(ErrorMessage = "Mã khách hàng không được để trống!")]
        public string Makh { get; set; }
        [DisplayName("Tên khách hàng")]
        [Required(ErrorMessage = "Tên khách hàng không được để trống!")]
        public string Tenkh { get; set; }
        [DisplayName("Năm sinh")]
        [Required(ErrorMessage = "Năm sinh không được để trống!")]
        public int? Namsinh { get; set; }
        [DisplayName("Phái")]
        [Required(ErrorMessage = "Phái không được để trống!")]
        public bool? Phai { get; set; }
        [DisplayName("Số điện thoại")]
        [Required(ErrorMessage = "Số điện thoại không được để trống!")]
        public string Dienthoai { get; set; }
        [DisplayName("Địa chỉ")]
        [Required(ErrorMessage = "Địa chỉ không được để trống!")]
        public string Diachi { get; set; }
        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống!")]
        public string Password { get; set; }

        public ICollection<Phieudathang> Phieudathang { get; set; }
    }
}
