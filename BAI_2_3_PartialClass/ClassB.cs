using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_3_PartialClass
{
    internal partial class ClassA//class A đang nằm trên cả file class B
    {
        public int Variable3 { get; set; }
        public int Variable4 { get; set; }

        public void Method3()
        {
            Console.WriteLine("đm chang");
        }
        partial void Method2(string a)
        {
            Console.WriteLine("đm chang");
        }
    }
}
