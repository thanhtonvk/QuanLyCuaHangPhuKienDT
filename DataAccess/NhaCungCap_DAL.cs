﻿using QuanLyCuaHangPhuKienDT.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using QuanLyCuaHangPhuKienDT.DataAccess.Interface;
namespace QuanLyCuaHangPhuKienDT.DataAccess
{
    class NhaCungCap_DAL : INhaCungCap
    {
        static string filepath = "NhaCungCap.txt";
        public void DocFile(ArrayList arrayList)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(filepath))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        string[] arr = line.Split("#");
                        arrayList.Add(new NhaCungCap(arr[0], arr[1],arr[2]));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void GhiFile(ArrayList arrayList)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(filepath))
                {
                    foreach (NhaCungCap NhaCungCap in arrayList)
                    {
                        streamWriter.WriteLine(NhaCungCap.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
