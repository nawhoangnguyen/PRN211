using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nawhn.Runner.DeathRacer
{
    internal interface Racer
    {//là một dạng class cha đặc biệt chứa những hàm abstract ko có code
     //còn được gọi chính là những câu lạc bộ
     //CLB có tiêu chí hoạt động, các member class con tham gia vào thì phải
     //theo tiêu chí CLB
     //TIÊU CHÍ HOẠT ĐỘNG, HÀNH ĐỘNG
     //SẼ LÀ ABSTRACT, ĐỂ ANH EM TỰ DO TRIỂN KHAI
     //CLB ĐUA THÌ TIÊU CHÍ HOẠT ĐỘNG SẼ LÀ RunToDeath()
     //hành động này là abstract
     //vì run() tùy thuộc mỗi người: run() kiểu TUNG MÌNH TRÊN XE NHƯ NGỌC TRINH
     //RUN() KIỂU THÁO THẮNG
        public double RunToDeath();

        //mặc định các hàm trong interface là abstract và ta thậm chí không 
        //cần ghi ra từ khóa abstract giống như bên abstract class
        //~~~~ nói kiểu gần đúng: inteface giống giống abstract class
        //ngược lại thì không
        //CON MUỐN GHI DANH THÌ IMPLEMENT NHƯ BÊN ABSTRACT CLASS
        //NHƯNG CHỈ CẦN CODE CHO HÀM ABSTRACT LÀ ĐỦ
        //KHÔNG QUAN TÂM CONSTRUCTOR HAY KẾ THỪA HAY INFO HAY SUPER HAY BASE GÌ ĐÓ

        public string ShowRecord();
    }
}
