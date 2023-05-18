using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT
{
    internal class FileService
    {
        private static FileStream _fs;
        private static BinaryFormatter _bf;

        /// <summary>
        /// Phương thức lưu file
        /// </summary>
        /// <param name="path">Đường dẫn lưu file</param>
        /// <param name="datas">Các đối tượng cần lưu</param>
        /// <returns></returns>
        public static string SaveFile(string path, List<VnVaccine> datas)
        {
            _fs = new FileStream(path, FileMode.Create);
            _bf = new BinaryFormatter();//Khởi tạo
            _bf.Serialize(_fs, datas);
            _fs.Close();
            return "Lưu file thành công";
        }

        public static string ReadFile(string path)
        {
            List<VnVaccine> lstTeamData = new List<VnVaccine>();
            _fs = new FileStream(path, FileMode.Open);
            _bf = new BinaryFormatter();
            var data = _bf.Deserialize(_fs);
            lstTeamData = (List<VnVaccine>)data;
            foreach (Vaccine v in lstTeamData)
            {
                v.inRaManHinh();
            }
            return lstTeamData.Count.ToString();

        }
    }
}