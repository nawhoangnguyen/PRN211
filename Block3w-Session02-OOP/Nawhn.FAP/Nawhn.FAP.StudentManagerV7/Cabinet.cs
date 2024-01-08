using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaz.FAP.StudentManagerV7
{
    /// <summary>
    /// Class này dùng để lưu trữ tối đa 30 hồ sơ sv
    /// Class này cung cấp các hàm CRUD hồ sơ sv
    /// </summary>
    internal class Cabinet
    {

        //1 tủ chứa nhiều hồ sơ sv
        //chứa 1 mảng các Student
        //thay vì khai báo mảng ở Main(), thì ta khai báo ở Tủ
        //để sau Main có thể có nhiều Tủ
        //Khai báo mảng lẻ bên Main() khó viết CRUD sv
        //OOP tốt, new Tủ() CRUD không cần viết lại
        private Student[] _list = new Student[30]; //_list là 1 mảng chưa nhiều hồ sơ sv
        private int _count = 0; //khởi đầu class _count = 0, khi gọi hàm add new count +1


        //Tủ sẽ có hành động CRUD
        /// <summary>
        /// Hàm này sẽ lưu mới 1 hồ sơ sv vào bên trong, tối đa 30 sv
        /// Bạn cần cung cấp 1 object sv đã được new ở đâu đó trước
        /// </summary>
        /// <param name="s"></param>
        /// 
        public void AddNewStudent(Student s)
        {
            //hàm này nhập thông tin từ đâu đó, đưa nguyên con new Student, object tham chiếu vào 
            _list[_count] = s;
            _count++;
        }
        /// <summary>
        /// Hàm này dùng để in ra các hồ sơ sinh viên đang được lưu trữ
        /// </summary>
        public void PrintStudentListByIdAsc()
        {
            Console.WriteLine($"There is/are {_count} Students. The Student List ascending by Id: ");
            //Sắp xếp id trược khi in
            for (int i = 0; i < _count-1; i++)
            {
                for (int j = i + 1; j < _count; j++)
                {
                    if (_list[i].Id.CompareTo(_list[j].Id) > 0)
                    {
                        var tmp = _list[i];
                        _list[i] = _list[j];
                        _list[j] = tmp;
                    }
                }
            }
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_list[i]);  //gọi thêm ToString() của từng bạn sinh viên
                //[] chỉ mới là biến SV, phải . tiếp để yêu cầu SV làm gì đó
            }

        }
        public void PrintStudentListByGpaDesc()
        {
            Console.WriteLine($"There is/are {_count} Students. The Student List descending by Gpa: ");
            //Sắp xếp id trược khi in
            for (int i = 0; i < _count - 1; i++)
            {
                for (int j = i + 1; j < _count; j++)
                {
                    if (_list[i].Gpa < _list[j].Gpa)
                    {
                        var tmp = _list[i];
                        _list[i] = _list[j];
                        _list[j] = tmp;
                    }
                }
            }
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_list[i]);  //gọi thêm ToString() của từng bạn sinh viên
                //[] chỉ mới là biến SV, phải . tiếp để yêu cầu SV làm gì đó
            }

        }

        public void AddNewStudent()
        {

        }

    }
}
