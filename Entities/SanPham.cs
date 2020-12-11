using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCuaHangPhuKienDT.Entities
{
    class SanPham
    {
        private string maphukien, tentruyen, theloai;
        private int giachothue, soluongcu, soluongmoi;
        public SanPham(string maphukien,string tentruyen,string theloai,int giachothue,int soluongcu,int soluongmoi)
        {
            this.maphukien = maphukien;
            this.tentruyen = tentruyen;
            this.theloai = theloai;
            this.giachothue = giachothue;
            this.soluongcu = soluongcu;
            this.soluongmoi = soluongmoi;
        }
        override
            public string ToString()
        {
            return maphukien + "#" + tentruyen + "#" + theloai + "#" + giachothue + "#" + soluongcu + "#" + soluongmoi;
        }
        public string Maphukien { get => maphukien; set => maphukien = value; }
        public string Tentruyen { get => tentruyen; set => tentruyen = value; }
        public string Theloai { get => theloai; set => theloai = value; }
        public int Giachothue { get => giachothue; set => giachothue = value; }
        public int Soluongcu { get => soluongcu; set => soluongcu = value; }
        public int Soluongmoi { get => soluongmoi; set => soluongmoi = value; }
    }
}
