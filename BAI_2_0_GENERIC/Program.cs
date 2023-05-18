using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_0_GENERIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int x = 9, y = 11;
            Console.WriteLine($"x={x},y={y}");
            HoanViThamTri(x, y);
            Console.WriteLine($"Hoán vị tham trị x={x}, y={y}");
            HoanViThamChieu(ref x, ref y);
            Console.WriteLine($"Hoán vị tham chiếu x={x}, y={y}");

            double x1 = 99.9, x2 = 33.2;
            HoanViThamTri_GENERIC(x1, x2);
            string x3 = "A", x4 = "B";
            HoanViThamTri_GENERIC(x3, x4);
        }
        static void HoanViThamTri_GENERIC<T>(T a, T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        static void HoanViThamTri(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void HoanViThamChieu(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
