namespace Nawhn.DataType.DelegateAdvance
{
    //TẠO DELEGATE GIỐNG NHƯ TẠO RA 1 DATATYPE MỚI ĐỀ XÀI
    //TA SẼ ĐẶT CÂU LỆNH TAO DELEGATE NẰM NGOÀI CLASS - MẠNH NGANG CLASS, INTERFACE
    //NHƯNG CÚ PHÁP NGẮN GỌN HƠN, DO NÓ CHỈ CHỌN ĐỂ LƯU/TRỎ ĐẾN 1 LOẠI HÀM NÀO ĐÓ
    public delegate void SayXXX();//TÔI SẼ NÓI VE 1 LOẠI HÀM CÓ CÙNG STYLE.FORMAT
                                  //SayXXX tương đương class Student, class Lecture
                                  //KHUÔN CHỨA BÊN TRONG NHIỀU GÌ ĐÓ, NHIỀU THÊN HÀM
    internal class Program
    {
        static void Main(string[] args)
        {
            //đỉnh cao của delegate
            //HÀM ẨN DANH - HÀM VÔ DANH - ANONYMOUS FUNCTION
            //SayXXX f = ???? // TA CẦN một cái hàm nào đó có style void Tên-Ham();
            //??? LÀ TÊN 1 HÀM NÀO ĐÓ CÓ SẴN ĐÂU ĐÓ, CÓ STYLE VOID TÊN HÀM()
            //HÀM BẢN CHẤT LÀ XỬ LÍ BÊN TRONG; THAY VÌ TA CẦN TẠO 1 HÀM NÓ ĐÓ SẴN
            //TA CÓ THỂ TẠO HÀM STYLE TAKE_ÂY, ON-THE-GÓ
            SayXXX f = delegate () { Console.WriteLine("Hello delegate"); };
            //Bỏ bớt dấu ngoặc
            SayXXX f1 = delegate { Console.WriteLine("Hello delegate V2"); };
            //Viết ngắn gọn hàm bỏ dấu ()
            SayXXX f2 = () => Console.WriteLine("Hello delegate V3"); 
            f();
        }

        //static void Main(string[] args)
        //{
        //    Student s = new Student()
        //    {
        //        Id = "SE1",
        //        Name = "An Nguyễn",
        //        Yob = 2003,
        //        Gpa = 7.9
        //    };
        //    SayXXX f = s.SayHello;
        //    f += Student.SayMath;
        //    f.Invoke();

        //}
        //static void Main(string[] args)
        //{
        //    //SayXX f = ?? //tên hàm nào đó có style void Ten-Ham() //callback
        //    //tên hàm bây giờ được xem là value cho 1 biến nào đó - biến kiẻu delegate
        //    SayXXX f = SayHelloWorld;
        //    f();
        //    //f += SayHello ko dùng vì là nonstatic
        //    //non static thì chơi theo cách new class cha
        //    Program program = new Program(); //non static phải đi qua con đường new 

        //    f += program.SayHello;
        //    f();


        //}
        public static void SayHelloWorld() => Console.WriteLine("Hello everyone, this message comes from SayHelloWorld() method");
        public void SayHello() => Console.WriteLine("Hello");
    }
}