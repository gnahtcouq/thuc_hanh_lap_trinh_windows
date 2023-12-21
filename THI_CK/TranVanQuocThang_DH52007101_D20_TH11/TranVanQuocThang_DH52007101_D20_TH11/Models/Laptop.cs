using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TranVanQuocThang_DH52007101_D20_TH11.Models {
    public partial class Laptop {
        public Laptop() {
            ChiTietHoaDon = new HashSet<ChiTietHoaDon>();
        }
        [DisplayName("Mã laptop")]
        [Required(ErrorMessage = "Mã laptop không được để trống!")]
        [StringLength(maximumLength: 10, ErrorMessage = "Mã laptop không được quá 10 ký tự")]
        public string MaLaptop { get; set; }
        [DisplayName("Tên laptop")]
        [Required(ErrorMessage = "Tên laptop không được để trống!")]
        [StringLength(maximumLength: 30, ErrorMessage = "Tên laptop không được quá 30 ký tự")]
        public string TenLaptop { get; set; }
        [DisplayName("Ngày sản xuất")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [Required(ErrorMessage = "Ngày sản xuất không được để trống!")]
        public DateTime? NgaySx { get; set; }
        [DisplayName("Đơn giá")]
        [Required(ErrorMessage = "Đơn giá không được để trống!")]
        [Range(0, int.MaxValue, ErrorMessage = "Đơn giá không hợp lệ!")]
        public int? DonGia { get; set; }
        [DisplayName("Mã nhà sản xuất")]
        //[Required(ErrorMessage = "Mã nhà sản xuất không được để trống!")]
        public string MaNsx { get; set; }
        [DisplayName("Mô tả")]
        [Required(ErrorMessage = "Mô tả không được để trống!")]
        public string MoTa { get; set; }

        public NhaSanXuat MaNsxNavigation { get; set; }
        public ICollection<ChiTietHoaDon> ChiTietHoaDon { get; set; }
    }
}
