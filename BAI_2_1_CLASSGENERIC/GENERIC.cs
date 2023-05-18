using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_1_CLASSGENERIC
{
    internal class GENERIC<Q>
    {
        private Q temp;

        public GENERIC()
        {

        }

        public GENERIC(Q temp)
        {
            this.temp = temp;
        }

        public Q Temp
        {
            get => temp;
            set => temp = value;
        }

        public Q getVaule()
        {

            Console.WriteLine(temp);
            return temp;
        }
    }
}
