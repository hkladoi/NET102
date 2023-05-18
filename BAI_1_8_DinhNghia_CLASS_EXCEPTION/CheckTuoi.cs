using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_8_DinhNghia_CLASS_EXCEPTION
{
    internal class CheckTuoi : Exception
    {
        public int Age { get; set; }

        public CheckTuoi(string mesage, int age) : base(mesage)
        {
            Age = age;
        }

        public void ThongBaoLoi()
        {
            Console.WriteLine($"Tuổi {Age} của bạn chưa thể đăng ký học");
        }
    }
}
