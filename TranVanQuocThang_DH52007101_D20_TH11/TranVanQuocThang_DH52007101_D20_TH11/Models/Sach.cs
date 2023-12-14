using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TranVanQuocThang_DH52007101_D20_TH11.Models {
    public partial class Sach {
        public Sach() {
            ChiTietPhieuMuon = new HashSet<ChiTietPhieuMuon>();
        }
        [DisplayName("Mã sách")]
        [Required(ErrorMessage = "Mã sách không được để trống!")]
        [StringLength(maximumLength: 10, ErrorMessage = "Mã sách không được quá 10 ký tự")]
        public string MaSach { get; set; }
        [DisplayName("Tên sách")]
        [Required(ErrorMessage = "Tên sách không được để trống!")]
        [StringLength(maximumLength: 30, ErrorMessage = "Tên sách không được quá 30 ký tự")]
        public string TenSach { get; set; }
        [DisplayName("Ngày xuất bản")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [Required(ErrorMessage = "Ngày xuất bản không được để trống!")]
        public DateTime? NgayXb { get; set; }
        [DisplayName("Giá")]
        [Required(ErrorMessage = "Giá không được để trống!")]
        [Range(0, int.MaxValue, ErrorMessage = "Giá tiền không hợp lệ!")]
        public int? Gia { get; set; }
        [DisplayName("Mã loại sách")]
        [Required(ErrorMessage = "Mã loại sách không được để trống!")]
        public string MaLoai { get; set; }

        public LoaiSach MaLoaiNavigation { get; set; }
        public ICollection<ChiTietPhieuMuon> ChiTietPhieuMuon { get; set; }
    }
}
