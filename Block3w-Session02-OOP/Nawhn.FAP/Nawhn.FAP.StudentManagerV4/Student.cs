using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Nawhn.FAP.StudentManagerV4
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //nếu chỉ muốn có phần kia đi thì xóa get và set

        //nếu một class không có constructor tức là ko có phễu
        //vè logic cáci khuôn chính kà cái class 
        //nếu đen ra để đúc object, thì ta sẽ có 1 object không khi
        //tức là một khuôn rỗng không có value thì se tạo được một object mang giá trị mặc định
        //NEW CÁI CLASS MÀ KO CÓ CONSTRUCTOR - GIÔ GS BẺ KHUÔN RA KO ĐỔ VALUE GÌ CẢ
        //NEW CÁI CLASS MÀ KO CÓ CONSTRUCTOR - TA ĐÚC ĐƯỢC 1 OBJECT KHÔNG KHÍ,
        //                                   - TA ĐÚC ĐƯỢC 1 OBJECT MÀ CÁC FIELD BÊN TRONG DEFAULT
        //SỐ DEFAULT LÀ 0, CHUỖI DEFAULT LÀ RỖNG HOẶC NULL, TRUE/FALSE DÈAULT FALSE

        //constructor rỗng là constructor ko có tham số đầu vào, do nothing
        //giúp ta đúc ra 1 object rỗng info - 1 object ko khí - 1 object default value

        public Student()
        {

        }

        public override string? ToString()
        {
            return @$"Student profile   
                                           Id : {Id} 
                                         Name : {Name}";
        }

    }
}


