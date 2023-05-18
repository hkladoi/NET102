using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_5_NULLABLE_TYPED
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Phần 1:null
            classA class1, class2;
            class1 = new classA();//khởi tạo tham chiếu bằng 1 đối tượng
            class2 = class1;//class2 đc gán class1 tham chiếu đến cùng 1 đối tượng class1
            class2.Method1();

            //class 1 = null
            #endregion

            #region Phần 2:NULLABLE TYPED
            Nullable<int> temp = null;
            Nullable<long> temp2 = null;
            int? temp3 = 20;
            int? temp4 = null;

            if (temp4.HasValue)
            {
                //body
            }
            Console.WriteLine(temp4.GetValueOrDefault());//giá trị mặc định là 0

            int? temp5 = null;
            int temp6 = temp5 ?? 0;//temp6 =temp5 khi temp5 != null,temp6 = 0 khi temp5 = null

            #endregion
        }
        class classA
        {
            public void Method1()
            {

            }
        }
    }
}
