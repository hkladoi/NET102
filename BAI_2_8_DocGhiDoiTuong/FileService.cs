using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_8_DocGhiDoiTuong
{
    internal class FileService
    {
        private static FileStream _fs;
        private static BinaryFormatter _bf;

        //ghi dữ liệu vào file thì phải biết file đó ở đâu
        //và dữ liệu ghi vào file là dữ liệu gì
        public static void WriteFile(string path, List<Meo> data)
        {
            _fs = new FileStream(path, FileMode.Create);
            _bf = new BinaryFormatter();//khởi tạo
            _bf.Serialize(_fs, data);
            _fs.Close();
        }
        //đọc file lên và trả ra 1 list đối tượng từ file
        public static List<Meo> ReadFile(string path)
        {
            _fs = new FileStream(path, FileMode.Open);
            _bf = new BinaryFormatter();//khởi tạo
            var dataReader = _bf.Deserialize(_fs);
            _fs.Close();
            return (List<Meo>)dataReader;
        }
    }
}
