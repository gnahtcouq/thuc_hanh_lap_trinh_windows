using System;
using System.Collections.Generic;

namespace TranVanQuocThang_DH52007101_D20_TH11.Models
{
    public partial class ChiTietPhieuMuon
    {
        public string MaPm { get; set; }
        public string MaSach { get; set; }

        public PhieuMuon MaPmNavigation { get; set; }
        public Sach MaSachNavigation { get; set; }
    }
}
