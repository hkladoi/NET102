using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1_6_EXCEPTION
{
    internal class Program
    {
        static void Vidu1()
        {
            int a = 5, b = 0, c;
            c = a / b;//Exception: System.DivideByZeroException: Attempted to divide by zero.
            Console.WriteLine(c);
            Console.WriteLine("Kết thúc chương trình");
        }
        /*
         * Lưu ý:
         * 1. Cách sử dụng"
         * - Chi sử dụng khi nộp bài ở những môn dự án 1, Dự Án tốt nghiệp.
         * - Khi nào đóng gói cho bên Tester và khách hàng thì phải đóng.
         */
        static void Vidu2()
        {
            int a = 5, b = 0, c;
            try
            {
                c = a / b;
                Console.WriteLine(c);
            }
            catch (Exception e)
            {
                Console.WriteLine("Các lỗi xảy ra: ");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.GetType().Name);
            }
            Console.WriteLine("Kết thúc chương trình");
        }

        //finally
        static void Vidu3()
        {
            try
            {
                int a = 5, b = 0, c;
                c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException)
            {
                //thực hiện 1 hành động nào đó
            }
            catch (FormatException)
            {

            }
            catch (Exception)
            {

            }
            finally
            {
                Console.WriteLine("finally");
            }
            Console.WriteLine("Kết thúc chương trình");
        }
        static void Main(string[] args)
        {
            Vidu3();
        }
    }
}
