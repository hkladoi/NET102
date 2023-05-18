using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            VnVaccineService vc = new VnVaccineService();

            string input;
            do
            {
                Console.WriteLine("1: nhập");
                Console.WriteLine("2: xuất");
                Console.WriteLine("3: sắp xếp");
                Console.WriteLine("4: lọc");
                Console.WriteLine("5: xoá");
                Console.WriteLine("6: sửa");
                Console.WriteLine("7: lưu file");
                Console.WriteLine("8: đọc file");
                Console.WriteLine("9: tìm kiếm");
                Console.WriteLine("0: thoát");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        vc.Nhap();
                        break;
                    case "2":
                        vc.Xuat();
                        break;
                    case "3":
                        vc.SX();
                        break;
                    case "4":
                        vc.Loc();
                        break;
                    case "5":
                        vc.Xoa();
                        break;
                    case "6":
                        vc.sua();
                        break;
                    case "7":
                        vc.GhiFile();
                        break;
                    case "8":
                        vc.DocFile();
                        break;
                    case "9":
                        vc.TimKiem();
                        break;
                    case "0":
                        Console.WriteLine("Bạn có chắc muốn lưu file trước khi thoát không ? \n 1:Lưu 2.Thoát");
                        int a = Convert.ToInt32(Console.ReadLine());
                        if (a == 1)
                        {
                            vc.GhiFile();
                        }
                        if (a == 2)
                        {
                            Environment.Exit(0);
                        }
                        break;
                    default:
                        break;
                }
            } while (true);
        }
    }
}
