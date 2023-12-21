using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TranVanQuocThang_DH52007101_D20_TH11.Models {
    public partial class HoaDon {
        public HoaDon() {
            ChiTietHoaDon = new HashSet<ChiTietHoaDon>();
        }
        [DisplayName("Mã hoá đơn")]
        [Required(ErrorMessage = "Mã hoá đơn không được để trống!")]
        [StringLength(maximumLength: 5, ErrorMessage = "Mã khách hàng không được quá 5 ký tự")]
        public string MaHd { get; set; }
        [DisplayName("Ngày hoá đơn")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [Required(ErrorMessage = "Ngày hoá đơn không được để trống!")]
        public DateTime? NgayHd { get; set; }
        [DisplayName("Tổng tiền")]
        [Required(ErrorMessage = "Tổng tiền không được để trống!")]
        [Range(0, int.MaxValue, ErrorMessage = "Tổng tiền không hợp lệ!")]
        public int? TongTien { get; set; }
        public ICollection<ChiTietHoaDon> ChiTietHoaDon { get; set; }
    }
}
