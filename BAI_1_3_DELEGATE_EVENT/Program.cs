using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_3_DELEGATE_EVENT
{
    internal class Program
    {
        //Bước 1: Tạo 1 Delegate
        delegate void UpdateNam(string name);
        //Bước 2: Tạo class
        class SinhVien
        {
            public event UpdateNam nameChange;
            private string name;
            public string Name
            {
                get => name; set
                {
                    name = value;
                    //Kiểm tra để gọi ra sự kiện khi tên
                    //tác động một giá trị
                    if (nameChange != null)
                    {
                        nameChange(name);
                    }
                }
            }
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
                SinhVien sv = new SinhVien();
                sv.nameChange += Sv_nameChange;//Gõ += tab sẽ zen ra
                                               //1 pthuc skien
                sv.Name = "dungna";
                Console.WriteLine("Tên mới: " + sv.Name);
                sv.Name = "C#2";
                Console.WriteLine("Tên mới: " + sv.Name);
            }

            private static void Sv_nameChange(string name)
            {
                Console.WriteLine("Thông báo giá trị mới của name: " + name);
                Console.ReadKey();
            }
        }
    }
}
