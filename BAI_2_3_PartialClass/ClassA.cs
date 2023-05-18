using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_3_PartialClass
{
    internal partial class ClassA
    {
        public int Variable1 { get; set; }
        public int Variable2 { get; set; }

        public void Method1()
        {
            Console.WriteLine("đm chang");
        }
        /*
         * patial k có body code
         * bạn có thể dùng từ khoá patial trong khai báo phương thức,tuy 
         * nhiên mục đích chỉ để chia làm 2 nơi,1 nơi làm khai báo và 1 nơi triển khai
         */
        partial void Method2(string a);
    }
}
