using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_2_DELEGATE_ACTION_FUNC_PREDICATE
{
    internal class Program
    {
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
        public static void ThongTin3(string noidung, int a)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("ThongTin3: " + noidung);
            Console.ResetColor();
        }
        public static int PhepChia(int a, int b)
        {
            return a / b;
        }
        public static bool CheckVietHoa(string name)
        {
            return name.Equals(name.ToUpper());
        }
        static void Main(string[] args)
        {
            #region Phần 1: Action -chỉ đi vs void
            Action action;// tương đương delegate void tenDelegate()
            Action<string> action2;//tương đương delegate void tenDelegate(stringa)
            Action<string, int> action3; //tương đương delegate void tenDelegate(stringa,int b)
            Action<string, string, string, int> action4;
            action2 = ThongTin1;
            action2("Action");
            action2?.Invoke("action2");
            #endregion

            #region Phần 2:Pericate -chỉ đi vs bool
            Predicate<string> predicate;//tương đương delegate bool tenDelegate(stringa)
            predicate = CheckVietHoa;
            Console.WriteLine("chữ: " + predicate.Invoke("dung"));
            #endregion

            #region Phần 3 : Func-đi vs tất cả phương thức trả về
            //tham số cuối cùng chính là kiểu trả về
            Func<int, int, int> func1;
            func1 = PhepChia;
            Func<int, int, double, string> func2;
            #endregion

            //bài tập 
            Func<double, double, string, int> funcbt1;
            funcbt1 = ;
        }

    }
}