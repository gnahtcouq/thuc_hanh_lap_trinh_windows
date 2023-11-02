using System;
using System.Collections.Generic;

namespace DH52007101.Models
{
    public partial class Chitietphieugiaohang
    {
        public string Mapgh { get; set; }
        public string Mahang { get; set; }
        public string Donvitinh { get; set; }
        public double? Soluong { get; set; }

        public Hanghoa MahangNavigation { get; set; }
        public Phieugiaohang MapghNavigation { get; set; }
    }
}
