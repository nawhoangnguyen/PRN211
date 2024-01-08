using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nawhn.FAP.StudentManagerV8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cabinet<Student> sCabinet = new Cabinet<Student>();
            sCabinet.AddNew(new Student() { Id = "SE10", Name = "An Nguyen", Yob = 2003, Gpa = 9.3 });
            Student s = new Student() { Id = "SE01", Name = "Binh Le", Yob = 2001, Gpa = 8.6 };
            sCabinet.AddNew(s);//tóm lại hàm add new cần một vùng new student
            

            // IN SAU, ĐỂ CHỨNG MINH, CÓ THÊM TỦ MỚI ĐỰNG HỒ SƠ GV, KO ẢNH HƯỞNG TỦ CŨ - ĐỰNG
            //HỒ SƠ SINH VIÊN
            Cabinet<Lecturer> lCabinet = new Cabinet<Lecturer>();
            lCabinet.AddNew(new Lecturer() { Id = "00001", Name = "Ms. Lisa"});
            lCabinet.AddNew(new Lecturer() { Id = "00002", Name = "Mr. Kdot" });
            
            //nước sông không đụng nước giếng
            Console.WriteLine("Student list");
            sCabinet.PrintList();
            Console.WriteLine("Lecturer list");
            lCabinet.PrintList();

        }
    }
}
