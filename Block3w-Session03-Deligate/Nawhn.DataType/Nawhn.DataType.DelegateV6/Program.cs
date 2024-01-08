namespace Nawhn.DataType.DelegateV6
{
    public delegate int Fn(); //mới tạo ra datatype gon,đặt tên chung cho 1 nhóm hàm
    //cúng style int
    public delegate char Fc(string s, int index);
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    //Xài gọi hàm gián tiếp, tức là ko lôi cổ trực tiếp tên hàm ra gọi mà hàm vẫn chạy
        //    //gọi trực tiép
        //    Console.WriteLine("Call function directly:  " +  Fx());
        //    //gọi gián tiếp
        //    Fn f = Fx;
        //    Console.WriteLine("Call function indirectly:  " + f());
        //    //gọi gián tiếp hàm tập 2 - ko gọi hàm sẵn có, mà tạo hàm bị trỏ theo style
        //    //on-the-go, take-away -  chơi với hàm CHƯA CÓ SẴN!!! ANONYMOUS FUNC, LAMBDA
        //    f = delegate ()
        //    {
        //        return 100;
        //    };
        //    f = () => { return 100; };  
        //    f = () => 100;
        //    //in kết quả indirectly but using lamda
        //    Console.WriteLine("Call function indirectly using lamda expression: " + f());
        //}

        //static void Main(string[] args)
        //{
        //    //Fn f = ??? hàm int trả về int nào đó = Fx , vừa học xong
        //    Func<int> f = Fx;
        //    //gọi hàm gián tiếp và cũng nhận về 100
        //    Console.WriteLine("Call function indirectly but using Func<> : " + f());
        //    //TUI MÚN CHƠI VỚI HÀM NHẬN VÀO 2 THAM SỐ LÀ CHUỖI VÀ LÀ 1 CON SỐ
        //    //TRẢ VỀ CHAR 
        //    string i = "ahihi";
        //}
        static void Main(string[] args)
        {
            Fc f = ExtractCharacter;
            Console.WriteLine("The character at position of 5 of string Happy New Year is: " + f("Happy New Year ", 6));
            //KO ĐƯỢC XÀI DELEGATE TỰ TẠO ÀM XÀI HÀNG CHUẨN CỦA MS - NHƯ NHAU
            Func<string, int, char> a = ExtractCharacter;
            Console.WriteLine("The character at position of 5 of string Merry Christmas is: " + f("Merry Christmas", 6));
        }
        static char ExtractCharacter(string s, int index)
        {
            //TODO: dành thơi gian làm thêm check lố index ko thể extrac vị trí thứ 1-
            //và trả về null nếu ko có nếu index o phù hơp, qua lớn
            char result = s[index]; //chuỗi là mảng kí tự, và ta lấy kí tự thứ index của mảng
            return result;
        }

        static int Fx() => 100;
    }
}

