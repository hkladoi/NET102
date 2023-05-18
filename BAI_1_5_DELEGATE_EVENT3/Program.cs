using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_5_DELEGATE_EVENT3
{
    internal class Program
    {
        class NguoiDung
        {
            public event EventHandler suKienNhap2So;//Tương dương với 
            //delegate void ten(object sender, EventArgs e)
            public void nhapSo()
            {
                Console.WriteLine("Mời nhập số a: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời nhập số b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                suKienNhap2So.Invoke(this, new NguoiDung1(a, b));
            }
        }
        class NguoiDung1 : EventArgs
        {
            public int a { get; set; }
            public int b { get; set; }

            public NguoiDung1(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
        }
        class TinhToan
        {
            public void ThiHanh(NguoiDung nd)
            {
                nd.suKienNhap2So += TinhTong;
            }

            private void TinhTong(object sender, EventArgs e)
            {
                NguoiDung1 nd = (NguoiDung1)e;
                Console.WriteLine($"{nd.a} + {nd.b} = {nd.a + nd.b}");
            }
        }
        static void Main(string[] args)
        {
            //Phát đi sự kiện
            NguoiDung nd = new NguoiDung();

            //Nhận sự kiện
            TinhToan tt = new TinhToan();
            tt.ThiHanh(nd);

            //Thực thi
            nd.nhapSo();
        }
    }
}
