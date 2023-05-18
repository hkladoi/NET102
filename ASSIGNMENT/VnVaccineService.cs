using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT
{
    internal class VnVaccineService
    {
        private List<VnVaccine> _lstVac;
        private VnVaccine _vaccine;
        private string _input;

        public VnVaccineService()
        {
            FakeData();
        }

        private void FakeData()
        {
            _lstVac = new List<VnVaccine>();
            {
                new VnVaccine(1, "Abdala", "Cuba", 2020, 30, 1, 18, "gdg");
                new VnVaccine(2, "BBIBP-CorV", "Sinopharm", 2021, 31, 1, 20, "gưgw");
                new VnVaccine(3, "Pfizer", "Mỹ", 2000, 60, 2, 17, "g");
                new VnVaccine(4, "Covaxin", "Ấn độ", 2019, 29, 1, 15, "g");
                new VnVaccine(5, "Johnson & Johnson", "Mỹ", 2022, 28, 3, 16, "g");
                new VnVaccine(6, "Moderna", "Mỹ", 2019, 20, 2, 21, "g");
                new VnVaccine(7, "AstraZeneca", "Mỹ", 2018, 40, 2, 22, "g");
                new VnVaccine(8, "Sputnik V", "Trung Quốc", 2020, 18, 2, 18, "g");
                new VnVaccine(9, "Sputnik V", "Trung Quốc", 2020, 10, 2, 17, "g");
                new VnVaccine(10, "Pfizer", "Mỹ", 2016, 22, 2, 17, "g");

            }
        }

        public string GetInput(string msg)
        {
            Console.WriteLine($"mời bạn nhập {msg}");
            return Console.ReadLine();
        }

        public int getindexBYID()
        {
            return _lstVac.FindIndex(c => c.MaVCC == Convert.ToInt32(GetInput("mã")));
        }

        public void Nhap()
        {
            _input = GetInput("số lượng");
            for (int i = 0; i < Convert.ToInt32(_input); i++)
            {
                _vaccine = new VnVaccine();
                _vaccine.MaVCC = Convert.ToInt32(GetInput("mã"));
                _vaccine.TenVCC = GetInput("tên");
                _vaccine.NhaSX = GetInput("tên nhà sx");
                _vaccine.NamSX = Convert.ToInt32(GetInput("năm"));
                _vaccine.ThoiGianTacDung = Convert.ToInt32(GetInput("thời gian"));
                _vaccine.CongNghe = Convert.ToInt32(GetInput("công nghệ"));
                _vaccine.TuoiDuocPhepTiem = Convert.ToInt32(GetInput("tuổi"));
                _vaccine.GhiChu = GetInput("ghi chú");
                _lstVac.Add(_vaccine);
            }
        }

        public void Xoa()
        {
            var temp = getindexBYID();
            if (temp == -1) return;
            {
                _lstVac.RemoveAt(temp);
            }
        }

        public void Xuat()
        {
            foreach (var x in _lstVac)
            {
                x.inRaManHinh();
            }
        }
        public void SX()
        {
            _lstVac = _lstVac.OrderBy(c => c.MaVCC).ToList();
        }

        public void sua()
        {
            var temp = getindexBYID();
            if (temp == -1) return;
            {
                _lstVac[temp].TenVCC = GetInput("Tên");
            }
        }

        public void Loc()
        {
            Console.WriteLine("1. Theo thoi gian tac dung");
            Console.WriteLine("2. Theo ten");
            Console.WriteLine("3. Theo do tuoi duoc phep tiem");
            Console.WriteLine("Chon kieu loc:");
            int loc = Convert.ToInt32(Console.ReadLine());
            switch (loc)
            {
                case 1:
                    int tgtd = Convert.ToInt32(GetInput("Nhap thoi gian tac dung toi thieu:"));
                    _lstVac = _lstVac.Where(C => C.ThoiGianTacDung >= tgtd).ToList();
                    foreach (var x in _lstVac)
                    {
                        x.inRaManHinh();
                    }
                    break;
                case 2:
                    string tenvc = GetInput("Ten vaccine loc:");
                    _lstVac = _lstVac.Where(C => C.TenVCC.Contains(tenvc)).ToList();
                    break;
                case 3:
                    int dtt = Convert.ToInt32(GetInput("Nhap do tuoi tiem toi thieu:"));
                    _lstVac = _lstVac.Where(C => C.TuoiDuocPhepTiem >= dtt).ToList();
                    break;
                default:
                    Console.WriteLine("Ko co chuong trinh nay");
                    break;
            }
        }

        public void TimKiem()
        {
            _input = GetInput("vaccine muốn tìm");
            foreach (var x in _lstVac.Where(c => c.TenVCC.StartsWith(_input)).OrderBy(c => c.MaVCC).ToList())
            {
                x.inRaManHinh();
            }
        }

        public void GhiFile()
        {
            string path =
               @"C:\Users\anhtr\OneDrive - 31123\Documents\C#2\PH25050_NET102_BL1_SM22\ASSIGNMENT\GhiFile.bin";//ĐƯờng dẫn file lưu
            Console.WriteLine(FileService.SaveFile(path, _lstVac));
            Console.WriteLine("lưu thành công");
        }
        public void DocFile()
        {
            Console.WriteLine("Mở file thành công");
            _lstVac = new List<VnVaccine>();
            string path = @"C:\Users\anhtr\OneDrive - 31123\Documents\C#2\PH25050_NET102_BL1_SM22\ASSIGNMENT\GhiFile.bin";
            FileService.ReadFile(path);
        }
    }
}
