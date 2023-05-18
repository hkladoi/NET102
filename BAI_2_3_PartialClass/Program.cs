using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_3_PartialClass
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*
             * Phần 1: sử dụng PartialClass
             * khi sử dụng đối tượng ClassA hoàn toàn bình thường như các class đã
             * đc học chỉ khác nó đc tách làm 2
             */
            ClassA cla = new ClassA();
            cla.Variable1 = 1;
            cla.Variable3 = 2;
            cla.Method1();
            cla.Method3();
            /*
             * Phần 2: sử dụng class lồng nhau Nested
             * lớp nested đc khai báo,định nghĩa trong lớp container
             */
        }
    }
}
