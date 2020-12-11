using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCuaHangPhuKienDT.Entities
{
    class HoaDon
    {
        private string mahd, nv, ngaythanhtoan, matruyen, soluong, giachothue, tongtien, tenphukien;
        public HoaDon(string mahd,string nv,string ngaythanhtoan,string matruyen,string soluong,string giachothue,string tongtien,string tenphukien)
        {
            this.mahd = mahd;
            this.nv = nv;
            this.ngaythanhtoan = ngaythanhtoan;
            this.matruyen = matruyen;
            this.soluong = soluong;
            this.giachothue = giachothue;
            this.tongtien = tongtien;
            this.tenphukien = tenphukien;
        }
        override
            public string ToString()
        {
            return mahd + "#" + nv + "#" + ngaythanhtoan + "#" + matruyen + "#" + soluong + "#" + giachothue + "#" + tongtien + "#" + tenphukien;
        }
        public string Mahd { get => mahd; set => mahd = value; }
        public string Nv { get => nv; set => nv = value; }
        public string Ngaythanhtoan { get => ngaythanhtoan; set => ngaythanhtoan = value; }
        public string Matruyen { get => matruyen; set => matruyen = value; }
        public string Soluong { get => soluong; set => soluong = value; }
        public string Giachothue { get => giachothue; set => giachothue = value; }
        public string Tongtien { get => tongtien; set => tongtien = value; }
        public string Tenphukien { get => tenphukien; set => tenphukien = value; }
    }
}
