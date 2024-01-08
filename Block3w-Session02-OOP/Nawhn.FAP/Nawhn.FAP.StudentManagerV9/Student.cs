using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nawhn.FAP.StudentManagerV9
{
    internal class Student
    {
        public static string Id { get; set; } //đây là thiết kế sai
        //các đặc tính của object ko dùng static
        //nếu cố tình thì 1 object cùng 1 info

        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        public Student(string id)
        {
            Id = id;
        }
        //public Student(string id, string name, int yob, double gpa)
        //{
        //    Id = id;
        //    Name = name;
        //    Yob = yob;
        //    Gpa = gpa;
        //}


        public static void SayHello()
        {
            //Console.WriteLine("Hey, my name is " + Name);
            Console.WriteLine("By the way my Id is " + Id);
        }
        public override string? ToString() =>
           $"{Id} | {Name} | {Yob} | {Gpa}"; //interpolation
                                             //expression body
    }
}
//chốt hạ static chỉ chơi với static còn non static chơi với non-static và với static luôn
//muốn lấy static thì lấy static qua tên class . static vì nó là vùng
//dùng chung cho mọi object
// Vậy khi nào dùng static ?
//chỉ dùng static cho các hàm hay method mang ý nghĩa thư viện xài chung
//cho nhiều nơi và . để dùng trực tiếp ngay và luôn
//còn khi muốn lưu thông tin riêng lẻ cho từng object ta phải dùng non-static
// vd: Math. CÁC hàm tón học new làm gì chi cho tốn kém
//static khỏi new một vùng ram xử lí xong trả về !!!
//ko cần tạo object rườm rà
//dbutil có các hàm kết nối cơ sở dữ liệu là static
//dbutil . connection
//gọi trực tiếp qua tên class chấm -> mày chính là static
//Integer.parseInt() Double.parseDouble() gọi trực tiép ko new, trả về rồi thoy

