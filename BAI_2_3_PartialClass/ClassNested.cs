using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_3_PartialClass
{
    internal class ClassNested
    {
        public class classD
        {
            public int Variable1 { get; set; }

            public classD()
            {

            }

            public classD(int variable1)
            {
                Variable1 = variable1;
            }

            public void Method1()
            {

            }
        }
    }
}
