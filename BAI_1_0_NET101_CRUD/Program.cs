using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_0_NET101_CRUD
{
    internal class Program
    {
        /*
         * CRUD Meo
         */
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
                Console.WriteLine("6: thoát");
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
                        ms.timkiemGD();
                        break;
                    default:
                        break;
                }
            } while (input != "8");
            /*
            * Sau khi hoàn thành bài:
            * 6. Tìm kiếm gần đúng theo tên Mèo
            * 7. Tìm kiếm cân nặng mèo theo khoảng.
            * 8. Sắp xếp giảm dần danh sách mèo theo cân nặng (Không in ra.)
            */
        }
    }
}
