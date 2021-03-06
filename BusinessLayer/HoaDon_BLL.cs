﻿using QuanLyCuaHangPhuKienDT.BusinessLayer.Interface;
using QuanLyCuaHangPhuKienDT.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCuaHangPhuKienDT.BusinessLayer
{
    class HoaDon_BLL : IHoaDon
    {

        public HoaDon find(ArrayList arrayList)
        {
            Console.WriteLine("Nhập mã hoặc tên: ");
            string keyword = Console.ReadLine();
            HoaDon result = null;
            foreach (HoaDon HoaDon in arrayList)
            {
                if (keyword.Equals(HoaDon.Mahd) || keyword.Equals(HoaDon.Tenphukien))
                {
                    result = HoaDon;
                }
            }
            return result;

        }

        public void display(HoaDon HoaDon)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|{7,-20}|", HoaDon.Mahd, HoaDon.Nv, HoaDon.Ngaythanhtoan, HoaDon.Matruyen, HoaDon.Soluong, HoaDon.Giachothue, HoaDon.Tongtien, HoaDon.Tenphukien);
        }
        public void Hien(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|{7,-20}|", "Mã hóa đơn", "Nhân viên", "Ngày thanh toán", "Mã phụ kiện", "Số lượng", "Giá cho thuê", "Tổng tiền", "Tên phụ kiện");
            foreach (HoaDon HoaDon in arrayList)
            {
                display(HoaDon);
            }
        }

        public void Nhap(ArrayList arrayList)
        {


            string mahd = (arrayList.Count + 1000).ToString();
            Console.WriteLine("Nhập nhân viên");
            string nv = Console.ReadLine();
            Console.WriteLine("Nhập ngày thanh toán");
            string ngaythanhtoan = Console.ReadLine();
            Console.WriteLine("Nhập mã phụ kiện");
            string matruyen = Console.ReadLine();
            Console.WriteLine("Nhập số lượng");
            string soluong = Console.ReadLine();
            Console.WriteLine("Nhập giá cho thuê");
            string giachothue = Console.ReadLine();
            Console.WriteLine("Nhập tổng tiền");
            string tongtien = Console.ReadLine();
            Console.WriteLine("Nhập tên phụ kiện");
            string tenphukien = Console.ReadLine();
            arrayList.Add(new HoaDon(mahd, nv, ngaythanhtoan, matruyen, soluong, giachothue, tongtien, tenphukien));
        }

        public void Sua(ArrayList arrayList)
        {

            HoaDon kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {

                Console.WriteLine("Nhập nhân viên");
                kq.Nv = Console.ReadLine();
                Console.WriteLine("Nhập ngày thanh toán");
                kq.Ngaythanhtoan = Console.ReadLine();
                Console.WriteLine("Nhập mã phụ kiện");
                kq.Matruyen = Console.ReadLine();
                Console.WriteLine("Nhập số lượng");
                kq.Soluong = Console.ReadLine();
                Console.WriteLine("Nhập giá cho thuê");
                kq.Giachothue = Console.ReadLine();
                Console.WriteLine("Nhập tổng tiền");
                kq.Tongtien = Console.ReadLine();
                Console.WriteLine("Nhập tên phụ kiện");
                kq.Tenphukien = Console.ReadLine();
            }
        }

        public void TimKiem(ArrayList arrayList)
        {
            HoaDon kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {

                Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|{7,-20}|", "Mã hóa đơn", "Nhân viên", "Ngày thanh toán", "Mã phụ kiện", "Số lượng", "Giá cho thuê", "Tổng tiền", "Tên phụ kiện");
                display(kq);
            }
        }

        public void Xoa(ArrayList arrayList)
        {
            HoaDon kq = find(arrayList);
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
