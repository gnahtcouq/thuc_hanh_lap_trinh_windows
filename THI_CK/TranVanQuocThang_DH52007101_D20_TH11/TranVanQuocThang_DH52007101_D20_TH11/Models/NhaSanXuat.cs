using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TranVanQuocThang_DH52007101_D20_TH11.Models {
    public partial class NhaSanXuat {
        public NhaSanXuat() {
            Laptop = new HashSet<Laptop>();
        }
        [DisplayName("Mã nhà sản xuất")]
        //[Required(ErrorMessage = "Mã nhà sản xuất không được để trống!")]
        public string MaNsx { get; set; }
        [DisplayName("Tên nhà sản xuất")]
        //[Required(ErrorMessage = "Tên nhà sản xuất không được để trống!")]
        //[StringLength(maximumLength: 30, ErrorMessage = "Tên nhà sản xuất không được quá 30 ký tự")]
        public string TenNsx { get; set; }
        [DisplayName("Số điện thoại")]
        //[Required(ErrorMessage = "Số điện thoại không được để trống!")]
        //[Phone(ErrorMessage = "Số điện thoại không hợp lệ!")]
        public string SoDt { get; set; }
        [DisplayName("Email")]
        //[EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ!")]
        public string Email { get; set; }

        public ICollection<Laptop> Laptop { get; set; }
    }
}
