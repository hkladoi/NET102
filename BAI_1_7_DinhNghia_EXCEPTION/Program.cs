using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_7_DinhNghia_EXCEPTION
{
    internal class Program
    {
        #region tự định nghĩa ra 1 exception trong 1 phương thức
        static void CheckTuoiHocFPL(string TruongDK, int tuoi)
        {
            if (TruongDK != "FPOLY")
            {
                Exception exception = new Exception("bạn k thể đăng ký trường fpoly");
                throw exception;
            }

            if (tuoi < 18)
            {
                throw new Exception("bạn chưa đủ tuổi để học");
            }

            Console.WriteLine("đăng ký nhập học thành công");
        }
        #endregion

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                CheckTuoiHocFPL("FPOLY", 20);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
