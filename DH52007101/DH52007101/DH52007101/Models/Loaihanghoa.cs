using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DH52007101.Models {
    public partial class Loaihanghoa {
        public Loaihanghoa() {
            Hanghoa = new HashSet<Hanghoa>();
        }
        [DisplayName("Mã loại")]
        [Required(ErrorMessage = "Mã loại không được để trống!")]
        [StringLength(maximumLength: 5, ErrorMessage = "Mã loại hàng hoá không được quá 5 ký tự")]
        public string Maloai { get; set; }
        [DisplayName("Tên loại")]
        [Required(ErrorMessage = "Tên loại không được để trống!")]
        [StringLength(maximumLength: 30, ErrorMessage = "Tên loại hàng hoá không được quá 30 ký tự")]
        public string Tenloai { get; set; }

        public ICollection<Hanghoa> Hanghoa { get; set; }
    }
}
