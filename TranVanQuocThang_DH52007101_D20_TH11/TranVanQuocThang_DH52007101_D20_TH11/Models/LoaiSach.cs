using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TranVanQuocThang_DH52007101_D20_TH11.Models {
    public partial class LoaiSach {
        public LoaiSach() {
            Sach = new HashSet<Sach>();
        }
        [DisplayName("Mã loại sách")]
        [Required(ErrorMessage = "Mã loại sách không được để trống!")]
        public string MaLoai { get; set; }
        [DisplayName("Tên loại sách")]
        [Required(ErrorMessage = "Tên loại sách không được để trống!")]
        public string TenLoai { get; set; }

        public ICollection<Sach> Sach { get; set; }
    }
}
