using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            QLLT ql = new QLLT();
            string input;
            do
            {
                Console.WriteLine("1: nhập");
                Console.WriteLine("2: xuất");
                Console.WriteLine("3: sắp xếp");
                Console.WriteLine("4: xoá");
                Console.WriteLine("5: ds");
                Console.WriteLine("0: thoát");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        ql.Nhap();
                        break;
                    case "2":
                        ql.InDS();
                        break;
                    case "3":
                        ql.SX();
                        break;
                    case "4":
                        ql.Xoa();
                        break;
                    default:
                        break;
                }

            } while (input != "6");
        }
    }
}
