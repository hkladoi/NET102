using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_0_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrName = { "Hoa", "Trang", "Dũng", "Long", "Mạnh", "Hoàng", "Tùng", "Lan" };
            List<int> arrNumber = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            //VD1: lấy ra những ng có tên bằng chữ L

            var lst1 =
                from a in arrName
                where a.StartsWith("L")
                select a;
            foreach (var x in arrName.ToList().Where(c => c.StartsWith("L")))
            {
                Console.WriteLine(x);
            }
            //VD2: truy vẫn lấy các số chẵn
            var lst2 =
                from b in arrNumber
                where b % 2 == 0
                select b;

            var lst3 =
                from b in arrNumber
                where b % 2 == 0
                orderby b ascending //descending,lưu ý 
                //mặc định k điền thì luôn là asc
                select b;
        }
    }
}
