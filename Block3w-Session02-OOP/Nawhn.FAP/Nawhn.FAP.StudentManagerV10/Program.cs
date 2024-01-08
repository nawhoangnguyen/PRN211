namespace Nawhn.FAP.StudentManagerV10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //có hai cách new khi chơi với kế thừa Cha -> Con
            Student s1 = new Student("SE1", "An Nguyen", 2003, 7.0);

            //KHAI CHA NEW CON - MÀY BIẾT BỐ TAO LÀ AI KO
            Person s2 = new Student("SE2", "Nam Nguyen", 2003, 8.0);

            Person l1 = new Lecturer("SE2", "Benzema Nguyen", 2003, 9.0);
            Lecturer l2 = new Lecturer("SE3", "Ronaldo Nguyen", 2004, 7.0);

            //in ra thông tin chi tiết giảng viên, sinh viên
            s1.ShowProfile(); //hàm Con
            s2.ShowProfile(); //hàm Cha - Person

            l1.ShowProfile(); //hàm Cha - Person
            l2.ShowProfile(); //hàm Con
            Console.WriteLine("===================================");
            //bắt đầu đã khi đưa các con vào chung một mảng của cha
            //gọi hàm cha các con hưởng ứng -> tính đa hình xuất hiện
            //1 tên hàm có nhièu cách code/chạy/thực hiện khác nhau
            //gọi showprofile() của cha, các con xung phong chạy giùm
            //từ 1 hàm cha, có nhiều hàm con hưởng ứng -> đa xạ, đa hình (dạng)

            //Person[] list = new Person[4];
            //list[0] = s1;
            //list[1] = s2;
            //list[2] = l1;
            //list[3] = l2;
            Person[] list = new Person[] { s1, s2, l1, l2, new Student("SE39", "Chin", 999, 9) };
            foreach (Person x in list)
            {
                x.ShowProfile(); //gọi cha n đứa con chạy
            }

        }
    }
}