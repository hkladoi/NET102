using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_1_DELEGATE
{
    internal class Program
    {
        //khai báo delegate
        public delegate void ThongBao(string msg);
        public static void ThongTin1(string noidung)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ThongTin1: " + noidung);
            Console.ResetColor();
        }
        public static void ThongTin2(string noidung)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ThongTin2: " + noidung);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region Phần 1: khởi tạo delegate null
            Console.WriteLine("===Phần 1:khởi tạo delegate null===");
            ThongBao thongBao = null; //khai báo delegate và tên biến gán giá trị null
            thongBao = ThongTin1; //gán phương thức cho delegate và delegate sẽ trỏ đến phương thức đó
            thongBao?.Invoke("đm chang"); //? kt có null hay k nếu k thì sẽ thực thi
            #endregion

            #region Phần 2: Khởi tạo delegate
            Console.WriteLine("===Phần 2: Khởi tạo delegate===");
            ThongBao thongBao1 = new ThongBao(ThongTin2);
            thongBao1("Môn C#2");
            #endregion


            #region Phần 3: Multicast delegate
            Console.WriteLine("===Phần 3: Multicast delegate===");
            ThongBao thongBao2 = new ThongBao(ThongTin1);
            ThongBao thongBao3 = new ThongBao(ThongTin2);
            ThongBao multicast = thongBao2 + thongBao3;
            multicast += thongBao3;
            multicast -= thongBao3;
            multicast("đm thành");
            #endregion

            #region Phần 4: delegate callback
            Console.WriteLine("===Phần 4: delegate callback===");
            DelegateCallBack dcb = new DelegateCallBack(ThongTin3);
            CallBack(dcb);
            #endregion
            Console.ReadKey();
        }
        #region Phần 4: delegate callback
        public delegate void DelegateCallBack(int a);
        public static void ThongTin3(int temp)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("ThongTin3: " + temp);
            Console.ResetColor();
        }

        public static void CallBack(DelegateCallBack delegateCallBack)
        {
            Console.WriteLine("nhập số nguyên: ");
            int so = Convert.ToInt32(Console.ReadLine());
            delegateCallBack(so);
        }
        #endregion
    }
}
