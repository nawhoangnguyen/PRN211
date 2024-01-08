namespace Nawhn.CodeFirst.StudentMgt
{
    internal class Program
    {
        public static StudentDb db = new StudentDb();
        static void Main(string[] args)
        {

            //Student s1 = new Student() { Id = "SE01", Name = "AN NGUYỄN" };
            //Student s2 = new Student() { Id = "SE02", Name = "BENZEMA  NGUYỄN" };
            //Student s3 = new Student() { Id = "SE03", Name = "MESSI NGUYỄN" };
            //Student s4 = new Student() { Id = "SE04", Name = "AN NGUYỄN" };

            ////để kết nối, đưa đẩy data xuống CSDL, ta pgair bew StudentDb
            ////chứa bên trong kết nối CSDL ta vừa cấu hình            


            //db.Database.EnsureCreated(); //xài các hàm của class cha DbContext
            //TẠO DATABASE NẾU CHƯA TỒN TẠI\
            //db.Students.Add(s1);
            //db.Students.Add(s2);
            //db.Students.Add(s3);
            //db.Students.Add(s4);
            //db.SaveChanges();

            List<Student> result = db.Students.ToList();
            result.ForEach(student => { Console.WriteLine(student); });
            //in ra cho tui ai có tên là AN
            Console.WriteLine("========");
            Console.WriteLine("in ra ai có tên là AN");
            result.Where(x =>
            {
                if (x.Name.ToLower().Contains("an"))
                {
                    return true;
                }
                return false;
            }).ToList().ForEach(student => Console.WriteLine(student));
        }

    }
}