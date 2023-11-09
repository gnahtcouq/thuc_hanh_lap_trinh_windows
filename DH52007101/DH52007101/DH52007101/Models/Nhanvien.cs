using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DH52007101.Models {
    public partial class Nhanvien {
        public Nhanvien() {
            Phieugiaohang = new HashSet<Phieugiaohang>();
        }
        [DisplayName("Mã nhân viên")]
        [Required(ErrorMessage = "Mã nhân viên không được để trống!")]
        [StringLength(maximumLength: 5, MinimumLength = 1, ErrorMessage = "Mã nhân viên phải từ 1 đến 5 ký tự")]
        public string Manv { get; set; }
        [DisplayName("Tên nhân viên")]
        [Required(ErrorMessage = "Tên nhân viên không được để trống!")]
        [StringLength(maximumLength: 30, MinimumLength = 2, ErrorMessage = "Tên nhân viên phải từ 2 đến 30 ký tự")]
        public string Tennv { get; set; }
        [DisplayName("Ngày sinh")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [Required(ErrorMessage = "Ngày sinh không được để trống!")]
        public DateTime? Ngaysinh { get; set; }
        [DisplayName("Phái")]
        [Required(ErrorMessage = "Phái không được để trống!")]
        public bool? Phai { get; set; }
        [DisplayName("Địa chỉ")]
        [Required(ErrorMessage = "Địa chỉ không được để trống!")]
        [StringLength(maximumLength: 30, ErrorMessage = "Địa chỉ không được quá 30 ký tự")]
        public string Diachi { get; set; }
        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống!")]
        [StringLength(maximumLength: 30, ErrorMessage = "Mật khẩu không được quá 30 ký tự")]
        public string Password { get; set; }

        public ICollection<Phieugiaohang> Phieugiaohang { get; set; }
    }
}
