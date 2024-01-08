using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nawhn.LinqIntro.StudentMgt
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }
        public void ShowProfile()
        {
            Console.WriteLine($"{Id} {Name} {Yob} {Gpa}");
        }
        public void  SayHello(string msg)
        {
            Console.WriteLine("Hello all, this message come from a traditional method");
            Console.WriteLine(msg); //in tham số đầu vào style trăm năm nay

        }
        public void DoSomethingInFuture(Action f)
        {
            //SV HÀM DOSOMETHING MUỐN CHẠY MUỐN GỌI THÌ PHẢI CHUYỀN VÀO 1 DELEEGATE
            //TỨC LÀ PHẢI CHUYỀN VÀO CHO NÓ MỘT HÀM VOID f ở đâu đó
            //ta đưa 1 hàm vào trong hàm này
            //kĩ thuật Truyền hàm vào hàm
            //COI HÀM LÀ THAM SỐ, LÀ DATA TYPE ĐƯA  VÀO, ĐC GỌI LF LẬP TRÌNH HÀ
            //FUNCTIONAL PROGRAMMING
            //HÀM ĐƯA VÀO HÀM, CÒN ĐC GOỊ LÀ ĐƯA 1 PHỤ THUỘC, 1 TÍNH TÓN, XỬ LÍ
            //LOGIC:BÊN NGOÀI VÀO HÀM NÀY, GỌI LÀ DEPENDENCY ỊNECTION
            //DI SẼ GIÚP MỞ RỘNG KHẢ NĂNG HÀNH ĐỘNG CỦA 1 CLASS, LINH HOẠT
            //VỚI CÁC XỬ LÍ SẼ ĐẾN TỪ TƯƠNG LAI, AI XÀI SAU NÀY CỨ ĐƯA VÀO THEO CÁCH CỦA HỌ
            //CỨ ĐƯA VÀO f() CỦA MÀY VÀO, TAO GỌI CHO CALL-BACK
            f();//tao gọi hàm bên ngoài của mày đưa vô
                //bên ngoài mày làm gì cx đc, tai nhắm mắt gọi!!!!


        }
    }
}
