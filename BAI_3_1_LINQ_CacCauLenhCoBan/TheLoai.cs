﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_1_LINQ_CacCauLenhCoBan
{
    class TheLoai
    {
        public int Id { get; set; }
        public string MaTheLoai { get; set; }
        public string TenTheLoai { get; set; }
        public bool TrangThai { get; set; }



        public void InRaManHinh()
        {
            Console.WriteLine($"{Id} | {MaTheLoai} | {TenTheLoai} | {TrangThai}");
        }
    }
}