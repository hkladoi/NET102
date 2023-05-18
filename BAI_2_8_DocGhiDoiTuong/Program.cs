using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_8_DocGhiDoiTuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            MeoService ms = new MeoService();
            string input;
            do
            {
                Console.WriteLine("1: thêm");
                Console.WriteLine("2: sửa");
                Console.WriteLine("3: xoá");
                Console.WriteLine("4: tìm kiếm");
                Console.WriteLine("5: xuất ds");
                Console.WriteLine("6: lưu");
                Console.WriteLine("7: đọc");
                Console.WriteLine("8: thoát");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        ms.Them1();
                        break;
                    case "2":
                        ms.sua();
                        break;
                    case "3":
                        ms.xoa();
                        break;
                    case "4":
                        ms.timkiem();
                        break;
                    case "5":
                        ms.InDS();
                        break;
                    case "6":
                        ms.LuuFile();
                        break;
                    case "7":
                        ms.DocFile();
                        break;
                    default:
                        break;
                }
            } while (input != "8");
        }
    }
}
