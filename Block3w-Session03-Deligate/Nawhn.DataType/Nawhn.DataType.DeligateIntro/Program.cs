namespace Nawhn.DataType.DelegateIntro
{
    delegate void SayXXX(); // biến để nói về hàm nào đó cụ thể
                            // biến SayXXX f = tên hàm cụ thể nào đó
                            //=> biến SayXX f = SayHello
                            //
                            //Hết sức lưu ý khi gán value cho biến delegate !!! cầm không được dùng ngoặc tròn ở tên hàm được gán
                            //vì ngoặc trong là gọi con mẹ nó hàm chứ gán cái đ gì
                            //mình đang gán value thôi mà
                            //~ int   => biến int x = 10 để nói về 1 value thuộc int
                            //~ Student => biến Student s1 = {...info}
                            //~ Lecturer => biến Lecturer l1 = {...info}

    internal class Program
    {

        static void Main(string[] args)
        {
            //xài SayXXX nhưu mọi data type khác, chỉ có điều gán value thay vì 5 10 15 20
            //thì lại là tên của một hàm khác
            //generic đại diện cho bất kì class nào
            //deligate đại diện/thay mới/ủy quyền cho bất kì hàm nào - cùng style
            SayXXX f = SayHi; //khai báo biến và gán
            //Vietsub câu này ~~ int x = 10

            //gán rồi thì dùng bình thường
            Console.WriteLine("Cach goi thu 1");
            f();
            //gọi f() chính là gọi SayHello() hàm được gọi một cách gián tiếp
            //nó đã ủy quyền cho thằng f gọi giùm thay vì gọi trực tiếp
            Console.WriteLine("Cach goi thu 2");
            f.Invoke();
            //=> f đang trỏ SayHi 
            //Giang hồ gọi delegate kĩ thuật con trỏ hàm
            //dùng 1 tên khác để trỏ đến cái hàm gốc
            //tên khác gọi hàm cũng như gọi hàm trức tiếp


            //KO AI CẤM 1 BIẾN THAY ĐỔI VALUE
            //KHÔNG AI CẤM 1 BIẾN DELEGATE TRỎ SANG HÀM KHÁC CÙNG STYLE VÀ GỌI HÀM KHÁC

            f = SayHelloWorld;
            f.Invoke();

            //Vi diệu trước giờ  chỉ nghe 1 biến chỉ lưu được 1 value
            //Delegate lưu được nhiều hàm cùng một lúc
            // thay vì một hàm như hai lệnh ở trên
            // vì bản chất là object
            //ta xài toán từ += để nhồi các hàm vào trong delegate
            Console.WriteLine("=========================");
            Console.WriteLine("Delegate invoke nhiều hàm");
            f += SayHelloEveryone;
            f += SayHelloDoctor;
            //như vậy trong ram f đang lưu 3 hàm
            //~~ luật sư đại diện nhièu thân chủ
            f();          
            //tức là em trỏ nhiều hàm
        }
        //ta có nhiều hàm cùng style void tên hàm và không nhận đầu vào
        //HÀM NHẬN ĐẦU VÀO VÀ O TRẢ ĐẦU RA
        //CÒN NHIỀU STYLE KHÁC. VÍ DỤ: NHẬN 1 INT, VÔ SỐ STYLE KHÁC
        //TỪ KHÓA DELEGATE MẠNH NGANG TỪ KHÓA INTERFACE
        //NÓ GIÚP TA DEFINE ĐỊNH NGHĨA RA 1 KIỂU DỮ LIỆU MỚI HOÀN TOÀN
        //DÙNG ĐỂ LƯU VALUE, ĐẶT TÊN CHO CÁC VALUE
        //int: kiểu dữ liệu cho value à đại lượng nguyên con 1,2,3,4,5,6,...
        //double: kiểu dữ liệu cho value có style là đại lượng lẻ lẻ miếng, bể 1 góc, 0 ,1.1,2.1,2.2
        //Person, Student: kiểu dữ liệu cho value có style là object phức tạp info id/name/yob/address
        //dùng từ khóa class/interface để define kiểu dữ liệu object phức tạp 

        //NẾU TA CÓ TRONG TAY RẤT HIỀU HÀM ĐỒNG DẠNG CÙNG STYLE, VẬY TA MUỐN ĐẶT TÊN CHO ĐÁM NÀ, MÚN
        //TẠO DATA TYPE MỚI MÀ CHỈ TẬP TRUNG VÀO CÁC HÀM MÀ THÔI, THÌ TA DÙNG TỪ KHÓA delegate

        //BẢN CHẤT DELEGATE CHÍNH LÀ 1 DẠNG CLASS MÀ CHỈ TẬP TRUNG VÀO VIỆC LƯU TRỮ THÔNG TIN CỦA CÁC
        //HÀM NẰM RẢI RÁC TRÊN CUỘC ĐỜI NÀY
        public static void SayHi() => Console.WriteLine("Hello everyone, this message comes from SayHi() method");

        public static void SayHelloWorld() => Console.WriteLine("Hello everyone, this message comes from SayHelloWorld() method");

        public static void SayHelloEveryone() => Console.WriteLine("Hello everyone, this message comes from SayHelloEveryone() method");

        public static void SayHelloDoctor() => Console.WriteLine("Hello everyone, this message comes from SayHelloDoctor() method");

    }
}