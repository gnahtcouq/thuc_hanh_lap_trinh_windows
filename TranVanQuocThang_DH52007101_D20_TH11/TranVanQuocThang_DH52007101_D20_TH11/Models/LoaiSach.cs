using System;
using System.Collections.Generic;

namespace TranVanQuocThang_DH52007101_D20_TH11.Models {
    public partial class LoaiSach {
        public LoaiSach() {
            Sach = new HashSet<Sach>();
        }

        public string MaLoai { get; set; }
        public string TenLoai { get; set; }

        public ICollection<Sach> Sach { get; set; }
    }
}
