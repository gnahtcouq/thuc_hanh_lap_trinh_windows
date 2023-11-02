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
        public string Maloai { get; set; }
        [DisplayName("Tên loại")]
        [Required(ErrorMessage = "Tên loại không được để trống!")]
        public string Tenloai { get; set; }

        public ICollection<Hanghoa> Hanghoa { get; set; }
    }
}
