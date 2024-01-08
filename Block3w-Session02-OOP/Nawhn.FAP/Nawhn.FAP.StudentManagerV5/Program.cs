namespace Nawhn.FAP.StudentManagerV5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new Student();
            //NẾU MỘT CLASS KO CÓ CONSTRUCTOR NÀO CẢ, MẶC ĐỊNH C# HOẶC JAVA
            //SẼ TẠO NGẦM GIÙM MỘT CONSTRUCTOR RỖNG
            //TA NEW BÌNH THƯỜNG VÀ SET BÌNH THƯỜNG
            //HOẶC NEW VÀ INITALIZER - SET LUÔN TRÊN LỆNH NEW
            s = new Student() { Id = "SE172704"};
            Console.WriteLine(s);//gọi thầm ToString()
            //constructor rông C# tạo gimf đc gọi là DEFAULT CONSTRUCTOR - MẶC ĐỊNH EM TẶNG ANH
            //1 CÁI CTOR - PHỄU NẾU ANH KO CHỊU LÀM RA PHỄU

            //NHƯNG NẾU CLASS ĐÃ CÓ CONSTRUCTOR NÀO SẴN TRƯỚC ĐÓ, THÌ C# KO THÈM TẠO GIÚP DEFAULT, EMPTY
            //CÓ BAO NHIÊU CONSTRUCTOR, CÓ BẤY NHIÊU CÁCH NEW - BẤY NHIÊU CÁCH ĐỔ
            //INFO VÀO BÊN TRONG OBJECT

            //NGOÀI RA CÒN CÓ CÁCH ĐỔ QUA NGÃ SETTER/INITALIZER
        }
    }
}