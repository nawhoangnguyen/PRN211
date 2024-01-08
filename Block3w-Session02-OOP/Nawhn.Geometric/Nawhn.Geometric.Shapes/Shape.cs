using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nawhn.Geometric._2DShapes
{
    internal abstract class Shape
    {
        //cha là nhân tử chung của con
        //con nào cũng có đặc điểm của cha mẹ
        //con cái thừa kế từ cha mẹ
        //hoặc hay cha mẹ là chung của các con
        //hình nói chung có hành đôngj gì thì con có i chang vậy
        //VUÔNG TRÒN CHỮ NHẬT TAM GIÁC HÌNH BÌNH HÀNH HÌNH THOI,. ...
        //THÌ ĐỀU CÓ MÀU SẮC TÊN GỌI DIỆN TÍCH
        //PHẦN CHUNG SẼ ĐỂ Ở CHA RIÊNG THÌ Ở CON
        //TRÒN THÌ CÓ BÁN KÍNH, TAM GIÁC THÌ CÓ 3 CẠNH
        //CHỮ NHẬT CÓ HAI CẠNH
        public string Name { get; set; }

        public string color { get; set; }

        public abstract double GetArea();//hàm tính diện tích là khái niệm tính bề mặt của 1 cái hình



        protected Shape(string name, string color)
        {
            Name = name;
            this.color = color;
        }
        //đo cụ thể ra sao, phải có hinh cụ thể mới nói chuyện được
        //ta để tên hàm ở đây vì là khái niệm cho mọi hình
        //nhưng ta chưa thể tính đc cụ thể số liệu do Hình chung chung
        //tồn tại ten hàm mang ý nghĩa khái niệm, chứ chưa tính đc
        //cụ thể -> HÀM CÓ TÊN NHƯNG KO CÓ CODE, CHƯA CÓ CODE => HÀM ABSTRACT
        //Làm thêm hàm in thông tin chi tiết
        //Làm thêm sort theo diện tích và in ra
        public abstract void ShowArea();


    }
}
