using System;
using System.Collections.Generic;

namespace TranVanQuocThang_DH52007101_D20_TH11.Models {
    public partial class ChiTietHoaDon {
        public string MaHd { get; set; }
        public string MaLaptop { get; set; }
        public int? SoLuong { get; set; }
        public int? DonGia { get; set; }

        public HoaDon MaHdNavigation { get; set; }
        public Laptop MaLaptopNavigation { get; set; }
    }
}
