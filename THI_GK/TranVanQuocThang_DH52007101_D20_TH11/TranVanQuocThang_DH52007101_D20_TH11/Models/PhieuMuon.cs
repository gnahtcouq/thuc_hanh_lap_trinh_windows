using System;
using System.Collections.Generic;

namespace TranVanQuocThang_DH52007101_D20_TH11.Models
{
    public partial class PhieuMuon
    {
        public PhieuMuon()
        {
            ChiTietPhieuMuon = new HashSet<ChiTietPhieuMuon>();
        }

        public string MaPm { get; set; }
        public DateTime? NgayMuon { get; set; }
        public DateTime? NgayTra { get; set; }

        public ICollection<ChiTietPhieuMuon> ChiTietPhieuMuon { get; set; }
    }
}
