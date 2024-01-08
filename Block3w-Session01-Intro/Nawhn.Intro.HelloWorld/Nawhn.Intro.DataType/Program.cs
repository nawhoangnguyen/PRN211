using Microsoft.VisualBasic;

namespace Nawhn.Intro.DataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============================");
            Console.WriteLine("=USING OUT=");
            //==================
            //  PlayWithIntegers();
            //  PlayWithNull();
            //xài hàm có từ khóa out, có 2 cách xài
            // cách 1: khai báo 3 biến ứng với 3 giá trị trả về
            int a, n1, n2;
            a = PlayWithOut(out n1, out n2);
            Console.WriteLine($"Play with a-b-c has values of {a} {n1} {n2}");
            // cách 2: không cần khai báo biến lẻ abc
            int d; //nhưng làm biếng khai báo lẻ e f để hứng 2 cái out
            d = PlayWithOut(out int e, out int f);//=> e f thoải mái dùng như b c ở cách 1
            Console.WriteLine($"Play with d-e-f has values of {d} {e} {f}");
            //==================
            Console.WriteLine("=============================");
            Console.WriteLine("=USING REF=");
            int x, y = 68, z = 69;
            Console.WriteLine($"Before calling Ref, y-z: {y} {z}");
            x = PlayWithRef(ref y, ref z);
            Console.WriteLine($"After calling Ref, x-y-z: {x} {y} {z}");
            //==================
            Console.WriteLine("=============================");
            Console.WriteLine($"Sum from 1 to 100 is => {Sum(100)}");
            Console.WriteLine("=============================");
            SumV2(100, out int sum);
            Console.WriteLine($"SumV2 from 1 to 100 is => {sum}");
            //==================
            Console.WriteLine("=============================");
            PlayWithArrayV1();
            Console.WriteLine("=============================");
            PlayWithArrayV2();

        }
        public static void PlayWithArrayV2()
        {
            int a = 10, b = 11, c = 12, d = 13;
            int[] arr = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };


            //In biến lẻ
            Console.WriteLine("Print conreted variable");
            Console.WriteLine($"Print conreted variable {a} {b} {c} {d}");
            Console.WriteLine($"Print conreted variable of array {arr[0]} {arr[1]} {arr[2]} {arr[3]}");
            //In biến cái một
            Console.WriteLine("=============================");
            Console.WriteLine("Print by modern for");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            
        }

        //MẢNG LÀ GÌ 
        //LÀ KĨ THUẬT KHAI BÁO NHIỀU BIẾN CÙNG 1 LÚC NHƯNG XÀI CHUNG 1 TÊN
        //XÀI CHUNG 1 TÊN Ở SÁT NHAU TRONG RAM
        //KHI CÁC BIẾN XÀI CHUNG TÊN, ĐỂ PHÂN BIỆT BIẾN NÀY VÀ BIẾN KHÁC TA DÙNG (STT)
        //VÍ DỤ
        // int a = 10,b = 11 , c = 12, d = 13;
        public static void PlayWithArrayV1()
        {
            int a = 10, b = 11, c = 12, d = 13;

            int[] arr = new int[100];
            arr[0] = 1; arr[1] = 2; arr[2] = 3; arr[3] = 4;
            arr[4] = 4; arr[5] = 5; arr[6] = 6; arr[7] = 7;

            //In biến lẻ
            Console.WriteLine("Print conreted variable");
            Console.WriteLine($"Print conreted variable {a} {b} {c} {d}");
            Console.WriteLine($"Print conreted variable of array {arr[0]} {arr[1]} {arr[2]} {arr[3]}");
            //In biến cái một
            Console.WriteLine("=============================");
            Console.WriteLine("Print unconreted variable");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }




        //SumV2
        public static void SumV2(int ip, out int sum)
        {
            sum = 0;
            for (int i = 0; i <= ip; i++)
                sum += i;

        }
        //VIẾT CHO TUI HÀM TRẢ VỀ TỔNG CỦA CÁC SỐ TỰ NHIÊN TỪ 1...100 -> 5050
        public static int Sum(int num)
        {
            int sum = 0;
            for (int i = 0; i <= num; i++)
                sum += i;
            return sum;
        }

        //hàm này chơi với từ khóa ref, khá giống out
        //giúp hàm trả về nhiều giá trị qua ngã theo tham số, thay vì qua return

        //REF GIỐNG OUT LÀ ĐỀU CÓ THỂ TRẢ VALUE RA BÊN NGOÀI
        //REF KHÁC OUT TRƯỚC KHI XÀI BÊN NGOÀI PHẢI CÓ MỘT VALUE NÀO ĐÓ
        //TRONG HÀM REF KHÔNG ÉP BIẾN REF PHẢI THAY ĐỔI VALUE, THÌ THÌ LÀM
        //OUT TRƯỚC KHI XÀI BIẾN NGOÀI CẦN GÁN VALUE
        //TRONG HÀM OUT CAM KẾT LUÔN CÓ VALUE TRẢ RA BÊN NGOÀI
        public static int PlayWithRef(ref int n1, ref int n2)
        {
            //n1 = 39;
            //n2 = 79;
            return 5;
        }







        //BÍ QUYẾT SÀI OUT: BIẾN ĐƯA VÀO HÀM KO CẦN KHỞI ĐỘNG VALUE
        //                  TRONG HÀM OUT BẮT BUỘC BIẾN OUT PHẢI ĐƯỢC GÁN VALUE
        //làm quen với ref, out
        //2 từ khóa mới giúp hàm trả về nhiều hơn 1 giá trị, ko qua ngả return
        //mà qua đầu vào, vùng Parameters/Argument để trả ra giá trị
        public static int PlayWithOut(out int n1, out int n2)
        {
            n1 = 10;
            n2 = 15;
            return 5;
        }

        //hàm dùng thử các lệnh if else forr while
        public static void PlayWithStatement()
        {

        }
        public static void PlayWithNull()
        {
            //null, chưa có gì cả, chưa xác định chính xác là gì, unknown
            //biến là một vùng ram chiếm 1 số byte nào đó tùy, dùng để lưu trữ dữ liệu
            //biến là 1 vùng ram đc đặt tên dùng chứa dữ liệu, vùng ram này mấy byte
            //tùy data mình sẽ chứa!!!
            //biến tên gọi 1 vùng ram chứa data
            //biến cách ta đặt tên cho 1 value - y chang toán học 
            int yob;
            yob = 2003; //CÚ PHÁP CHUẨN
            //yob = null | phải là một con số bất kì nào đó mới chịu


            int? age; //? ĐI KÈM IỂU DỮ LIỆU MANG 1 Ý NGHĨA MỚI: biến age vùng
                      //ram age cho phép chưa mang giá trị gì cả

            //age = 20; okk
            age = null;
            Console.WriteLine("yob: " + yob);
            Console.WriteLine("age: " + age);
            //khi ta khai báo 1 Biến VÀ CHƯA MUỐN XD VALUE CHO NÓ TA KHAI BÁO 
            //KÈM ? KẾ BÊN KIỂU DỮ LIÊUK -> KHO ĐÓ BIẾN ĐƯỢC PHÉP CHƯA XÁC ĐỊNH VALUE
            //<data type> ?  -> biến có thể gán value hoặc Null đều OKIE
            // Null vùng ram có gì ko quan tâm
            //KHI NÀO DÙNG ?
            //KHI CHƠI VỚI CƠ SỞ DỮ LIÊU - 1 CỘT NÀO ĐÓ TRONG TABLE CHƯA CÓ VALUE
            //ĐỒNG BỘ NÓ LÊN CODE CỦA MÌNH, TA CẦN STYLE ?
        }


        //hàm này dùng để thử nghiệm các biến lưu trữ số nguyên 
        //integer - the whole number - nguyên con không lẻ miếng nào
        public static void PlayWithIntegers()
        {
            int yob = 2003;
            Console.WriteLine("Your year of birth is: " + yob);
            int age = 2023 - yob;
            Console.WriteLine("And your age is: {0}", age);
            Console.WriteLine($"And your age is: {age}");
            //in chuỗi theo kiểu giữ chỗ placeholder
            //in kiểu nội suy giá trị trong chuỗi - interpolation 

            int fee = 28_000_000;
            //_ phân cách code cho dễ đọc
            Console.WriteLine("Your stuy fee ín a semester is: " + fee);

            //C# còn cung cấp thêm các kiểu dữ liệu: long, float, double, char, bool y chang
            //bên Java số byte giống Java long 8 byte double 8 byte float 4 byte 
            //các phép toán, if else, do, while, for, switch y chang Java
        }
    }
}