using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nawhn.FAP.StudentManagement
{
    internal class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        //phễu dùng để đổ thông tin vào bên trong 1 cái khuôn/class


        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        //ta có thể có nhièu cách đúc , điền info cho 1 object => 1 class
        //CÓ THỂ CÓ NHIỀU CONSTRUCTOR - CÁI PHỄU DÙNG ĐỂ ĐIỀN/ĐỔ INFO/VẬT LIỆU
        //MẶC ĐỊNH CÁC INFO CỦA 1 OBJECT,ĐẶC TÍNH MÔ TA CHO 1 OBJECT
        //NÓ SẼ LÀ PRIVATE ~~ BẠN MẶC QUẦN ÁO KHI RA ĐƯỜNG
        //VÀ KHI MÀ TA MUỐN PUBLIC INFO CỦA TA, TA CÓ 2 CÁCH
        //CÁCH 1:
        //CHO THIÊN HẠ THẤY MÀ KO CẦN HỎI XIN => DÙNG TỪ KHÓA PUBLIC
        //CÁCH 2:
        //DÙNG GET() METHOD => HỎI MỚI CHO NHA NÍ
        public double GetGpa() { return _gpa; }
        public string GetId() { return _id; }
        public string GetName() => _name;
        //CÚ PHÁP VIẾT HÀM THEO STYLE EXPRESSION BODY

        //NẾU HÀM CHỈ CÒN MỘT LỆNH, CHỈ CẦN 1 LỆNH
        //KO CARE HÀM CÓ RETURN HAY KO

        //TA CÓ NHU CẦU ĐỘ INFO CỦA MỘT OBJECT, MỤC SETTING TRONG ĐIỆN THOẠI GIÚP THAY ĐỔI INFO
        //VẬY HÀM SET ĐƯA INFO MỚI SẼ GIÚP THAY ĐỔI INFO CỦA MỘT OBJECT NÀO ĐÓ

        public void SetName(string name) { _name = name; }

        public void SetGPA(double gpa) => _gpa = gpa; 

        public void SetYob(int yob) =>  _yob = yob; //expression body

        //KHÁI NIẸM LẤY HÉT THÔNG TIN GỌI LÀ TOSTRING()
        //KHÁI NIẸM LẤY HÉT THÔNG TIN GỌI LÀ TOSTRING()

        public void GetAllInfo()
        {
            Console.WriteLine(@$"Student profile   
                                           Id : {_id} 
                                         Name : {_name} 
                                          Yob : {_yob} 
                                          Gpa : {_gpa}");            

        }



    }
}
