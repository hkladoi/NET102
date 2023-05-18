using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontap
{
    internal class QLLT
    {
        private List<laptop> _LstLaptops;
        private laptop _laptop;
        private string _input;

        public QLLT()
        {
            FakeData();
        }
        private void FakeData()
        {
            _LstLaptops = new List<laptop>()
            {
                new laptop(1, "Dell", 1.5),
                new laptop(2, "Asus", 2),
                new laptop(3, "MSI", 2.5)
            };
        }
        public void Nhap()
        {
            _input = GetInputValue("sl");
            for (int i = 0; i < Convert.ToInt32(_input); i++)
            {
                _laptop = new laptop();
                _laptop.MaLaptop = Convert.ToInt32(GetInputValue("Mã"));
                _laptop.Ten = GetInputValue("Tên");
                _laptop.TrongLuong = Convert.ToDouble(GetInputValue("trọng lượng"));
                _LstLaptops.Add(_laptop);
            }
        }
        public string GetInputValue(string msg)
        {
            Console.WriteLine($"mời bạn nhập {msg}: ");
            return Console.ReadLine();
        }
        public void Xoa()
        {
            for (int i = 0; i < _LstLaptops.Count; i++)
            {
                if (_LstLaptops[i].Ten.StartsWith("a"))
                {
                    _LstLaptops.RemoveAt(i);
                    Console.WriteLine("xoá thành công");
                }
            }
        }
        public void SX()
        {
            _LstLaptops = _LstLaptops.OrderByDescending(p => p.Ten).ToList();
        }
        public void InDS()
        {
            foreach (var x in _LstLaptops)
            {
                x.InThongTin();
            }
        }
    }
}
