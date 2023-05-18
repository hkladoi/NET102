using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_8_DocGhiDoiTuong

{
    [Serializable]

    internal abstract class dongvat
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double CanNang { get; set; }
        public int GioiTinh { get; set; }
        public dongvat()
        {

        }
        public dongvat(int id, string name, double canNang, int gioiTinh)
        {
            Id = id;
            Name = name;
            CanNang = canNang;
            GioiTinh = gioiTinh;
        }

        public abstract void InRaManHinh();

    }
}
