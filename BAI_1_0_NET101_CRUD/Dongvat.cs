using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_0_NET101_CRUD
{
    /*
     * Lớp cha
     * Lớp abstract thì bắt buộc phải có phương thức abstract
     */
    internal abstract class dongvat
    {
        //khai báo các property mà đối tượng cần phải có
        //prop + tab
        public int Id { get; set; }
        public string Name { get; set; }
        public double CanNang { get; set; }
        public int GioiTinh { get; set; }
        //phần 2: 2 contructor
        public dongvat()
        {

        }
        //Alt+enter => Gen...Contructor
        public dongvat(int id, string name, double canNang, int gioiTinh)
        {
            Id = id;
            Name = name;
            CanNang = canNang;
            GioiTinh = gioiTinh;
        }
        //phần 3:các phương thức
        public virtual void Method1(int a)
        {

        }
        public virtual void Method2(int a, int b)
        {

        }
        public void Method3(int a, int b)
        {

        }
        //phương thức abstract k có body code
        public abstract void InRaManHinh();
        /*tính đa hình
         * 1. Overloading (nạp chồng phương thức): Phương thức xảy ra khi phương thức 
         * trùng tên nhưng phải khác tham số.Khi sử dụng để gọi phương thức phải truyền 
         * đủ số lượng tham số và kiểu dữ liệu
         * 2. Overriding (ghi đè): Nhớ đến kế thừa,lớp con ghi đè lại phương thức lớp 
         * cha và lưu ý khi ghi đè bắt buộc phương thức tại lớp con phải giống tuyệt đối
         * 
         */
    }
}
