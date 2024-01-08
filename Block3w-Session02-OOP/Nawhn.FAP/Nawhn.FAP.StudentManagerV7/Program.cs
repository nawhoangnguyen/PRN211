using Kaz.FAP.StudentManagerV7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nawhn.FAP.StudentManagerV7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tư duy oop là tư duy ở hàm Main() mới bắt đầu app
            //Chỉ là nơi khai báo các Object và gọi hàm
            //OOP V6 Main() 
            //oop tốt sẽ là main() gọi tủ 

            //ta mua 1 tủ đựng hồ sơ sv của SE
            Cabinet tuSE = new Cabinet();
            tuSE.AddNewStudent(new Student() { Id = "SE10", Name = "An Nguyen", Yob = 2003, Gpa = 9.3 });
            Student s = new Student() { Id = "SE01", Name = "Binh Le", Yob = 2001, Gpa = 8.6 };
            tuSE.AddNewStudent(s);
            Console.WriteLine("Tu SE: ");
            tuSE.PrintStudentListByIdAsc();

            //oop tiện ở chỗ chúng ta có thể add nhiều tủ mà không cần viết lại nhiều code
            Cabinet tuBiz = new Cabinet();
            //tuBiz.AddNewStudent(new Student() { Id = "SE16", Name = "An Nguyen", Yob = 2001, Gpa = 5.0 });
            //Student sb = new Student() { Id = "SE17", Name = "Binh Le", Yob = 2001, Gpa = 6.5 };
            //tuBiz.AddNewStudent(sb);
            //Console.WriteLine("Tu Biz");
            //tuBiz.PrintStudentListByIdAsc();

            //Student s2 = new Student() { Id = "SE06", Name = "Hello", Yob = 2004, Gpa = 5.0 };
            //tuBiz.AddNewStudent(s2);
            //Console.WriteLine("Tu Biz again: ");
            //tuBiz.PrintStudentListByIdAsc();

            Student s1 = new Student() { Id = "SE04", Name = "Hello", Yob = 2002, Gpa = 6.0 };
            Student s2 = new Student() { Id = "SE34", Name = "Good Bye", Yob = 2001, Gpa = 7.3 };
            tuSE.AddNewStudent(s1);
            tuSE.AddNewStudent(s2);
            Console.WriteLine("Tu SE again: ");
            tuSE.PrintStudentListByIdAsc();



            Console.WriteLine("Tu SE again with Gpa descend: ");
            tuSE.PrintStudentListByGpaDesc();

        }
    }
}
