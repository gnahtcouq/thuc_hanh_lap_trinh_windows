using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DH52007101.Models {
    public partial class Nhasanxuat {
        public Nhasanxuat() {
            Hanghoa = new HashSet<Hanghoa>();
        }
        [DisplayName("Mã nhà sản xuất")]
        [Required(ErrorMessage = "Mã nhà sản xuất không được để trống!")]
        //[MinLength(10, ErrorMessage = "Mã nhà sản xuất phải nhập đủ 10 ký tự")]
        //[MaxLength(10, ErrorMessage = "Mã nhà sản xuất phải nhập đủ 10 ký tự")]
        [StringLength(maximumLength: 10, MinimumLength = 2, ErrorMessage = "Mã nhà sản xuất phải nhập đủ 2 ký tự")]
        public string Mansx { get; set; }
        [DisplayName("Tên nhà sản xuất")]
        [Required(ErrorMessage = "Tên nhà sản xuất không được để trống!")]
        public string Tennsx { get; set; }
        [DisplayName("Địa chỉ")]
        [Required(ErrorMessage = "Địa chỉ không được để trống!")]
        public string Diachi { get; set; }

        public ICollection<Hanghoa> Hanghoa { get; set; }
    }
}
