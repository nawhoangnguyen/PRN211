namespace Nawhn.FAP.StudentManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateStudents();
        }

        static void CreateStudents()
        {
            //lấy khuôn             chuẩn bị vật liệu           gọi phễu để đổ vào
            //class student         Angkara,Messi,10.0          Constructor
            Student s1 = new Student("SE172704", "NamNH", 2003, 8.6);

            Student s2 = new Student(id: "SE173979", name: "CR7", yob: 2003, gpa: 8.0);
            //new theo iểu chỉ ra tên của biến /tham số đầu vào
            //argument style

            Student s3 = new ("04", "Messi", 2003, 8.0);
            //kĩ thuật new rút gọn ko cần khai báo tên Class ở toán tử new

            s1.GetAllInfo();
            s2.GetAllInfo();
            s3.GetAllInfo();
        }
    }
}