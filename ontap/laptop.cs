using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontap
{
    internal class laptop
    {
        public int MaLaptop { get; set; }
        public string Ten { get; set; }
        public double TrongLuong { get; set; }

        public laptop()
        {

        }

        public laptop(int maLaptop, string ten, double trongLuong)
        {
            MaLaptop = maLaptop;
            Ten = ten;
            TrongLuong = trongLuong;
        }

        public void InThongTin()
        {
            Console.WriteLine($"mã là {MaLaptop} tên {Ten} có trọng lượng {TrongLuong}");
        }
    }
}
