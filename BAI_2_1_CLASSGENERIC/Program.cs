using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_1_CLASSGENERIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //vd1: sử dụng class generic
            GENERIC<double> genericdouble = new GENERIC<double>();
            genericdouble.Temp = 6.9;
            Console.WriteLine(genericdouble.Temp);
            /*
             * vd 2: triển khai 1 đối tượng có 1 thuộc tính
             * 
             */
            Console.WriteLine("nhập số lượng: ");
            int size = Convert.ToInt32(Console.ReadLine());
            ArrayGeneric<string> ag = new ArrayGeneric<string>(size);
            for (int i = 0; i < ag.Array.Length; i++)
            {
                Console.WriteLine($"mời bạn nhập phần tử thứ {i}");
                ag.AddArr(i, Console.ReadLine());
            }
            for (int i = 0; i < ag.Array.Length; i++)
            {
                Console.WriteLine(ag.GetValud(i) + " ");
            }

        }
    }
}
