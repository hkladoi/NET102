using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_8_DinhNghia_CLASS_EXCEPTION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CheckTuoiHocFPL("FPOLY", 17);
            }
            catch (CheckTruong e)
            {
                Console.WriteLine(e.Message);
            }
            catch (CheckTuoi e)
            {
                Console.WriteLine(e.Message);
                e.ThongBaoLoi();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void CheckTuoiHocFPL(string TruongDK, int tuoi)
        {
            if (TruongDK != "FPOLY")
            {
                CheckTruong exception = new CheckTruong("bạn k thể đăng ký trường fpoly");
                throw exception;
            }

            if (tuoi < 18)
            {
                throw new CheckTuoi("bạn chưa đủ tuổi để học", tuoi);
            }

            Console.WriteLine("đăng ký nhập học thành công");
        }
    }
}
