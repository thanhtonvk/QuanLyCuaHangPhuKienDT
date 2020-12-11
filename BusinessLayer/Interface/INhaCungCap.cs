using System;
using System.Collections;
using System.Text;

namespace QuanLyCuaHangPhuKienDT.BusinessLayer.Interface
{
    interface INhaCungCap
    {
        void Hien(ArrayList arrayList);
        void Nhap(ArrayList arrayList);
        void Sua(ArrayList arrayList);
        void TimKiem(ArrayList arrayList);
        void Xoa(ArrayList arrayList);

    }
}
