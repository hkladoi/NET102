using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_0_NET101_CRUD
{
    /*
     * Trong c# và JAVA chỉ có đơn kế thừa
     * khi lớp con kế thừa lớp cha là abstract thì bắt buộc phải ghi đè tất cả phương thức
     */
    internal class Meo : dongvat
    {
        //prop
        public string SoThich { get; set; }
        //ctor
        public Meo()
        {
        }

        public Meo(int id, string name, double canNang, int gioiTinh, string soThich = null) : base(id, name, canNang, gioiTinh)
        {
            SoThich = soThich;
            //this: tham chiếu đến thuộc tính và phương thức
            //base: tương tự this mà là của lớp cha
        }

        public override void Method1(int a)
        {
            base.Method1(a);
        }

        public override void Method2(int a, int b)
        {
            base.Method2(a, b);
        }

        public override void InRaManHinh()
        {
            Console.WriteLine($"{Id} {Name} {(GioiTinh == 1 ? "đực" : "cái")} {CanNang} {SoThich}");
        }
    }
}
