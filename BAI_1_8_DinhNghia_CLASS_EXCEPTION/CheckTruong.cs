using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_8_DinhNghia_CLASS_EXCEPTION
{
    internal class CheckTruong : Exception
    {
        public CheckTruong(string message) : base(message)
        {
        }
    }
}
