namespace Nawhn.FAP.StudentManagerV9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s2 = new Student(id: "SE2") { Name = "M10", Yob = 2003, Gpa = 122 };
            Student s1 = new Student("SE1") { Name = "CR7", Yob = 2003, Gpa = 120 };
            Student s3 = new Student("SE3") { Name = "B9", Yob = 2003, Gpa = 115 };
            Console.WriteLine("s1: " + s1.ToString());
            Console.WriteLine("s2: " + s2);
            Console.WriteLine("s2: " + s3);
            //STATIC LÀ VÙNG NHỚ XÀI CHUNG CHO CÁC OBJECT 
            //OBJECT NÀO CŨNG ĐƯỢC QUYỀN XÀI CŨNG XEM LÀ CỦA MÌNH
            //NÓ GIỐNG NHƯ CÁI WC TẬP THỂ
            //NHƯNG THỰC RA NÓ LÀ CỦA CHUNG CHO TOÀN BỘ CÁC OBJECT
            //ID LÚC NÀY DÙNG CHUNG CHO MỌI VÙNG NEW STUDENT CHO NÊN
            //PHẢI XEM ID LÀ CỦA CHUNG CỦA MỌI STUDENT
            //VẬY MUỐN LẤY ID THAY VÌ TỨNG BIẾN . ID RA CÙNG MỘT GIÁ TRỊ
            //TA CHỈ DÙNG STUDENT . ID LÀ ĐỦ V
            //VÌ MỌI THẰNG OBJECT ID CÙNG 1 VALUE
            //TUI MÚN IN ID CỦA CHUNG CHO MỌI SV
            Console.WriteLine("Id chung: " + Student.Id);
            Console.WriteLine("=====================================");
            //SayHelloV1(); //code này chạy ko được vì nằm trong ram ở đâu ko biêt
            //muốn chạy được thì phải là static
            SayHelloV2();

            //Muốn dùng SayHelloV1 phải đi qua vùng new
            Program x = new Program();
            x.SayHelloV1();
            Program.SayHelloV2();//static chơi qua tên class
            //tính giai thừa và vì mày là static
            Console.WriteLine("Giai thừa: " + MyToys.ComputeFactorial(5)); //static của mình
            //tương tực tính căn bâcj hai của 25 = 5
            Console.WriteLine("Căn bậc hai cua 25: " + Math.Sqrt(25)); //static của C#
            int.Parse(Console.ReadLine()); //đổi chữ sang số
            //Convert.ToByte... cũng là hàm static để convert thông tin từ dạng này sang dạng \khác
            //gõ tên class . thử nếu xổ ra có static để chơi không thì qua con đường new        
        }
        public void SayHelloV1() //say hello non-static
        {
            Console.WriteLine("Hey, this message comes from a non-static method");
        }

        public static void SayHelloV2() //say hello static
        {
            Console.WriteLine("Hey, this message comes from a static method");

        }
    }
}