using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_1_LINQ_CacCauLenhCoBan
{
    internal class Program
    {
        private static ServiceAll _sv = new ServiceAll();
        private static List<NhanVien> _lstNhanViens;
        private static List<TheLoai> _lstTheLoais;
        private static List<SanPham> _lsSanPhams;
        public Program()
        {
            _lstNhanViens = _sv.GetListNhanViens();
            _lstTheLoais = _sv.GetListTheLoais();
            _lsSanPhams = _sv.GetListSanPhams();
        }
        static void Main(string[] args)
        {
            //Gọi các ví dụ về lý thuyết lên để chạy
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Program program = new Program();//Khi khởi tạo thì các List trên sẽ có giá trị
            LINQ_0fType();
        }

        #region 1. Where điều kiện lọc

        static void LINQ_Where()
        {
            var lst1 =
                 (from a in _lstNhanViens
                  where a.TenNV.StartsWith("D") || a.TenNV.StartsWith("T")
                  select a).ToList();//list nhân viên

        }
        #endregion

        #region 2 Toán tử để lọc
        static void LINQ_0fType()
        {
            List<dynamic> lstString = new List<dynamic>() { 9, "chín", 10, 7, "bẩy" };

            var lst1 =
                from a in lstString.OfType<string>()
                select a;
            var lst2 =
                from a in lstString.OfType<int>()
                select a;
            Console.WriteLine("lstString.OfType<string>()");
            foreach (var x in lst1) Console.WriteLine(x);
            Console.WriteLine("lstString.OfType<int>()");
            foreach (var x in lst2) Console.WriteLine(x);
        }
        #endregion

        #region 3 orderby theo điều kiện
        static void LINQ_Orderby()
        {
            var lst1 =
                from a in _lsSanPhams
                orderby a.TenSP descending
                select a;
        }

        static void LINQ_Orderby_Thenby()
        {
            var lst1 =
                _lsSanPhams.OrderBy(c => c.TenSP).ThenBy(c => c.GiaBan).
                ThenByDescending(c => c.KickThuoc);
        }
        #endregion

        #region 4 group by 
        static void LINQ_Groupby()
        {
            List<string> lstName = new List<string> { "A", "A", "A", "NHAM", "NHAM", "NAM", "NAM" };
            var list =
                from a in lstName
                group a by a
                into g
                select g.Key;
            //VD1: lấy ra số lượng sản phẩm của các thể loại
            var lst2 =
                (from a in _lsSanPhams
                 group a by new
                 {
                     //nhóm nhiều cột
                     a.IdTheLoai
                 } into g
                 select new SanPham()
                 {
                     Id = g.Key.IdTheLoai,
                     IdTheLoai = g.Count(c => c.IdTheLoai == g.Key.IdTheLoai)
                 }).ToList();
            foreach (var x in lst2)
            {
                Console.WriteLine($"{x.Id} {x.IdTheLoai}");
            }
            //VD2 đếm số lượng sản phẩm theo màu sắc và tổng tiền đã nhập trên sản phẩm màu tương ứng
            var lst3 =
                (from a in _lsSanPhams
                 group a by new
                 {
                     //nhóm nhiều cột
                     a.MauSac
                 } into g
                 select new
                 {
                     Mau = g.Key.MauSac,
                     TongTien = g.Sum(c => c.GiaNhap),
                     Soluong = g.Count(c => c.MauSac == g.Key.MauSac)
                 }).ToList();
            foreach (var x in lst3)
            {
                Console.WriteLine($"{x.Mau} {x.TongTien} {x.Soluong}");
            }
        }
        #endregion

        #region 5 join

        static void LINQ_JOIN()
        {
            var lstSP =
                from a in _lsSanPhams
                join b in _lstTheLoais on a.IdTheLoai equals b.Id
                join c in _lstNhanViens on a.IdNhanVien equals c.Id
                where a.TrangThai
                select new
                {
                    Ma = a.MaSP,
                    Ten = a.TenSP,
                    Mau = a.MauSac,
                    TenTheLoai = b.TenTheLoai,
                    TenNV = c.TenNV
                };
        }
        #endregion
    }
}
