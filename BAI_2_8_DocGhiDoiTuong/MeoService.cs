using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_8_DocGhiDoiTuong
{
    //code các chức năng
    internal class MeoService
    {
        private List<Meo> _lstMeos;
        private Meo _meo;
        private string _input;
        string _pathFileData = @"C:\Users\anhtr\OneDrive - 31123\
        Documents\C#2\PH25050_NET102_BL1_SM22\BAI_2_8_DocGhiDoiTuong\data.bin";
        public MeoService()
        {
            fakeData();
        }
        private void fakeData()
        {
            _lstMeos = new List<Meo>()
            {
                new Meo(1, "A", 40, 1, "cá"),
                new Meo(2, "B", 40, 0, "thịt")

            };
        }
        public void Them1()
        {
            Console.WriteLine("mời bạn nhập số lượng");
            _input = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt16(_input); i++)
            {

                _meo = new Meo();
                _meo.Id = GetAutoID();
                Console.WriteLine("nhập tên: ");
                _meo.Name = Console.ReadLine();
                Console.WriteLine("cân nặng: ");
                _meo.CanNang = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("nhập giới tính: (1 Đực | 0 cái)");
                _meo.GioiTinh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("sở thích: ");
                _meo.SoThich = Console.ReadLine();
                _lstMeos.Add(_meo);
            }
        }

        public void timkiem()
        {

            var temp = getindexBYID();
            if (temp == -1) return;
            {
                _lstMeos[temp].InRaManHinh();
            }
        }
        public void timkiemGD()
        {
            string tim = GetInput("tên");
            foreach (var x in _lstMeos)
            {
                if (x.Name.StartsWith(tim))
                {
                    x.InRaManHinh();
                }
            }
        }
        public void xoa()
        {

            var temp = getindexBYID();
            if (temp == -1) return;
            {
                _lstMeos.RemoveAt(temp);
            }
        }
        public void sua()
        {

            var temp = getindexBYID();
            if (temp == -1) return;
            {
                _lstMeos[temp].Name = GetInput("Tên");
            }
        }

        public int getindexBYID()
        {

            return _lstMeos.FindIndex(c => c.Id == Convert.ToInt32(GetInput("ID")));
        }
        public void InDS()
        {
            foreach (var x in _lstMeos)
            {
                x.InRaManHinh();
            }
        }
        public string GetInput(string msg)
        {
            Console.WriteLine($"nhập {msg}: ");
            return Console.ReadLine();
        }
        public int GetAutoID()
        {
            if (_lstMeos.Count < 0)
            {
                return 1;
            }
            return _lstMeos.Max(c => c.Id) + 1;
        }

        public void LuuFile()
        {
            FileService.WriteFile(_pathFileData, _lstMeos);
            Console.WriteLine("lưu file thành công");
        }
        public void DocFile()
        {
            _lstMeos = FileService.ReadFile(_pathFileData);
            Console.WriteLine("đọc file thành công");
        }
    }
}