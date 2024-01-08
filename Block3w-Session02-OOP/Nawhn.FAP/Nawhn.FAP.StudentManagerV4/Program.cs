namespace Nawhn.FAP.StudentManagerV4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Id = 7;
            s.Name = "Ronaldo";
            Console.WriteLine("s after setting: " + s.ToString());

            Student ss = s;

            s = new Student();
            Console.WriteLine(s.ToString()); //rỗng mẹ rồi !!!!

            Console.WriteLine("SS nè, chính là s cũ ngày xưa: " + ss.ToString());

            s = ss;

            Console.WriteLine("s quay tro lai" + s.ToString()); //rỗng mẹ rồi !!!!
            //===============================================================
            Console.WriteLine("===============================================================");
            //néu class có empty cnstructor
            //ta new r set mới có info bên trong
            //nếu không set thì là default
            //CLASS INITALIZER - NEW VÀ KHỞI ĐỘNG/GÁN LUÔN INFO BÊN TRONG QUA SET
            Student s1 = new Student() { Id = 10, Name = "Messi", Description = "Angkara" };
            Console.WriteLine("s1 : " + s1.ToString());
            Student s2 = new () { Id = 7, Name = "Ronaldo", Description = "Incredible" };
            Console.WriteLine("s2 : " + s2.ToString()); //nếu ta in bín con trỏ, biến object, ToString() mặc định đc gọi
                                                        //Java và các ngông ngữ OOP y chang
                                                        //gọi thầm tên em ToString()

            var s3 = new Student() { Id = 10, Name = "Messi", Description = "Angkara" };
            //var tên biến chưa thêm xác định data type của biến là gì cho đến khi
            //gán giá trị thì mới biết kiểu của biến là gì - khai báo data type trễ !!!

        }
    }
}