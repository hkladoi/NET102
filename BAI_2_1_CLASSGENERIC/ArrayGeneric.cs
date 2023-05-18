using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_1_CLASSGENERIC
{
    internal class ArrayGeneric<T>
    {
        private T[] array;

        public ArrayGeneric()
        {

        }

        public ArrayGeneric(T[] array)
        {
            this.Array = array;
        }
        public ArrayGeneric(int size)
        {
            Array = new T[size];
        }

        public T[] Array { get => array; set => array = value; }



        //phương thức thêm phần tử
        public void AddArr(int index, T value)
        {
            if (index < 0 || index >= Array.Length)
            {
                throw new IndexOutOfRangeException();
            }
            array[index] = value;
        }
        //lấy giá trị trong mảng
        public T GetValud(int index)
        {
            if (index < 0 || index >= Array.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return Array[index];
        }
    }
}
