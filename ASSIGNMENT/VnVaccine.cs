using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT
{
    [Serializable]
    internal class VnVaccine : Vaccine
    {
        public int CongNghe { get; set; }
        public int TuoiDuocPhepTiem { get; set; }
        public string GhiChu { get; set; }

        public VnVaccine()
        {

        }

        public VnVaccine(int maVCC, string tenVCC, string nhaSX, int namSX, int thoiGianTacDung, int congNghe = 0, int tuoiDuocPhepTiem = 0, string ghiChu = null) : base(maVCC, tenVCC, nhaSX, namSX, thoiGianTacDung)
        {
            CongNghe = congNghe;
            TuoiDuocPhepTiem = tuoiDuocPhepTiem;
            GhiChu = ghiChu;
        }

        public override void inRaManHinh()
        {
            Console.WriteLine($"mã {MaVCC} tên {TenVCC} nhà sx {NhaSX} thời gian {ThoiGianTacDung} công nghệ {CongNghe} tuổi đc tiêm {TuoiDuocPhepTiem} ghi chú {GhiChu}");
        }
    }
}
