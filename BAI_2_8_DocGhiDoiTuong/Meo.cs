using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_8_DocGhiDoiTuong

{
    [Serializable]
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

        }

        public override void InRaManHinh()
        {
            Console.WriteLine($"{Id} {Name} {(GioiTinh == 1 ? "đực" : "cái")} {CanNang} {SoThich}");
        }
    }
}
