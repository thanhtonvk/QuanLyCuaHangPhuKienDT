using QuanLyCuaHangPhuKienDT.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyCuaHangPhuKienDT.BusinessLayer.Interface;
namespace QuanLyCuaHangPhuKienDT.BusinessLayer
{
    class SanPham_BLL :ISanPham
    {

        public SanPham find(ArrayList arrayList)
        {
            Console.WriteLine("Nhập mã hoặc tên: ");
            string keyword = Console.ReadLine();
            SanPham result = null;
            foreach (SanPham SanPham in arrayList)
            {
                if (keyword.Equals(SanPham.Maphukien) || keyword.Equals(SanPham.Tentruyen))
                {
                    result = SanPham;
                }
            }
            return result;

        }        //string maphukien,string tentruyen,string theloai,int giachothue,int soluongcu,int soluongmoi
        public void display(SanPham SanPham)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", SanPham.Maphukien, SanPham.Tentruyen, SanPham.Theloai, SanPham.Giachothue, SanPham.Soluongcu, SanPham.Soluongmoi);
        }
        public void Hien(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "Mã phụ kiện", "Tên phụ kiện", "Thể loại", "Giá cho thuê", "Số lượng cũ", "Số lượng mới");
            foreach (SanPham SanPham in arrayList)
            {
                display(SanPham);
            }
        }

        public void Nhap(ArrayList arrayList)
        {


            string masach = (arrayList.Count + 1000).ToString();
            Console.WriteLine("Nhập tên phụ kiện");
            string tentruyen = Console.ReadLine();
            Console.WriteLine("Nhập thể loại");
            string theloai = Console.ReadLine();
            Console.WriteLine("Nhập giá cho thuê");
            int giachothue = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số luợng cũ");
            int soluongcu = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số lượng mới");
            int soluongmoi = int.Parse(Console.ReadLine());
            arrayList.Add(new SanPham(masach,tentruyen,theloai,giachothue,soluongcu,soluongmoi));
        }

        public void Sua(ArrayList arrayList)
        {

            SanPham kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {

                Console.WriteLine("Nhập tên phụ kiện");
                kq.Tentruyen = Console.ReadLine();
                Console.WriteLine("Nhập thể loại");
                kq.Theloai = Console.ReadLine();
                Console.WriteLine("Nhập giá cho thuê");
                kq.Giachothue = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhập số luợng cũ");
                kq.Soluongcu = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhập số lượng mới");
                kq.Soluongmoi = int.Parse(Console.ReadLine());
                Console.WriteLine("Sửa thành công");
            }
        }

        public void TimKiem(ArrayList arrayList)
        {
            SanPham kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "Mã phụ kiện", "Tên phụ kiện", "Thể loại", "Giá cho thuê", "Số lượng cũ", "Số lượng mới"); 
                display(kq);
            }
        }

        public void Xoa(ArrayList arrayList)
        {
            SanPham kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                arrayList.Remove(kq);
                Console.WriteLine("Xóa thành công");
            }
        }
    }
}
