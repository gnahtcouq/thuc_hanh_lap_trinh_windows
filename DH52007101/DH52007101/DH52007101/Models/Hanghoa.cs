using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DH52007101.Models {
    public partial class Hanghoa {
        public Hanghoa() {
            Chitietphieudathang = new HashSet<Chitietphieudathang>();
            Chitietphieugiaohang = new HashSet<Chitietphieugiaohang>();
        }
        [DisplayName("Mã hàng hoá")]
        [Required(ErrorMessage = "Mã hàng hoá không được để trống!")]
        [StringLength(maximumLength: 5, ErrorMessage = "Mã hàng hoá không được quá 5 ký tự")]
        public string Mahang { get; set; }
        [DisplayName("Tên hàng hoá")]
        [Required(ErrorMessage = "Tên hàng hoá không được để trống!")]
        [StringLength(maximumLength: 30, ErrorMessage = "Tên hàng hoá không được quá 30 ký tự")]
        public string Tenhang { get; set; }
        [DisplayName("Đơn vị tính")]
        [Required(ErrorMessage = "Đơn vị tính không được để trống!")]
        [StringLength(maximumLength: 30, ErrorMessage = "Đơn vị tính không được quá 30 ký tự")]
        public string Donvitinh { get; set; }
        [DisplayName("Đơn giá")]
        [Required(ErrorMessage = "Đơn giá không được để trống!")]
        [StringLength(maximumLength: 30, ErrorMessage = "Đơn giá không được quá 30 ký tự")]
        public double? Dongia { get; set; }
        [DisplayName("Hình")]
        [Required(ErrorMessage = "Hình không được để trống!")]
        public string Hinh { get; set; }
        [DisplayName("Mã loại")]
        [Required(ErrorMessage = "Mã loại không được để trống!")]
        [StringLength(maximumLength: 30, ErrorMessage = "Mã loại không được quá 30 ký tự")]
        public string Maloai { get; set; }
        [DisplayName("Mã nhà sản xuất")]
        [Required(ErrorMessage = "Mã nhà sản xuất không được để trống!")]
        [StringLength(maximumLength: 30, ErrorMessage = "Mã nhà sản xuất không được quá 30 ký tự")]
        public string Mansx { get; set; }

        public Loaihanghoa MaloaiNavigation { get; set; }
        public Nhasanxuat MansxNavigation { get; set; }
        public ICollection<Chitietphieudathang> Chitietphieudathang { get; set; }
        public ICollection<Chitietphieugiaohang> Chitietphieugiaohang { get; set; }
    }
}
