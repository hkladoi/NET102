using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_6_ANONYMOUS_TYPED
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*
             * Phần 1: khai báo anonymous và anonymous lồng nhau
             */
            var SinhvienUDPM = new
            {
                ID = 1,
                MSV = "PH00533",
                Lop = "IT17329",
            };
            Console.WriteLine($"{SinhvienUDPM.ID} {SinhvienUDPM.MSV} {SinhvienUDPM.Lop}");

            Console.OutputEncoding = Encoding.UTF8;
            var SinhvienUDPM1 = new
            {
                ID = 1,
                MSV = "PH00533",
                Lop = "IT17329",
                DiaChi = new
                {
                    SoNha = 22,
                    Duong = "duogn 16"
                }
            };
            Console.WriteLine($"{SinhvienUDPM1.ID} {SinhvienUDPM1.MSV} {SinhvienUDPM1.Lop} {SinhvienUDPM1.DiaChi.SoNha}");
            /*
             * Phần 2:phương thức nặc danh
             */
            //Method1= nhẽ ra phải gán delegate này cho 1 phương thức tương ứng
            Method1 method1 = delegate (int i)
            {
                //có thể gọi các biến cục bộ bên ngoài thức nặc danh này
                Console.WriteLine("đây là phương thức nặc danh, giá trị: " + i);
            };
            method1(2022);//thực thi 
        }
        public delegate void Method1(int a);
    }
}
