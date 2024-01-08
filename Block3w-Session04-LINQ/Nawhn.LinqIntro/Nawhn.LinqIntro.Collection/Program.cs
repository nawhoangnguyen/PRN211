namespace Nawhn.LinqIntro.Collection
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        public override string ToString()
        {
            return $"{Id} | {Name} | {Yob} | {Gpa}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Id = "SE10", Name = "Messi", Yob = 2003, Gpa = 10 });
            students.Add(new Student { Id = "SE06", Name = "Sau", Yob = 2006, Gpa = 6 });
            students.Add(new Student { Id = "SE01", Name = "Mot", Yob = 2001, Gpa = 1 });
            students.Add(new Student { Id = "SE05", Name = "Nam", Yob = 2005, Gpa = 5 });
            students.Add(new Student { Id = "SE09", Name = "Benzema", Yob = 1976, Gpa = 9 });
            students.Add(new Student { Id = "SE07", Name = "Cristiano Ronaldo", Yob = 1995, Gpa = 6 });
            students.Add(new Student { Id = "SE08", Name = "Tony Kroos", Yob = 1998, Gpa = 2 });

            //tui muốn in ra danh sách tất cả sinh viên đang có
            //Cách 1: for truyền thống
            Console.WriteLine("====================================================");
            Console.WriteLine("The full student list by for i");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i].ToString());
            }
            //cách 2: for each truyền thống
            Console.WriteLine("====================================================");
            Console.WriteLine("The full student list by for each");
            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }

            //cách 3: LINQ nhận vào 1 delegate nhận vào 1 Hàm Check Var (Đầu vào 1 SV)
            //                                 Trả ra /true nếu sv thỏa check var
            Console.WriteLine("====================================================");
            Console.WriteLine("The full student list by for each LINQ Style");
            students.ForEach(x => Console.WriteLine(x.ToString()));
            Console.WriteLine("====================================================");
            Console.WriteLine("The full student list by for each LINQ Style using another function");
            students.ForEach(ShowStudent);
            Console.WriteLine("====================================================");
            Console.WriteLine("The list of student with GPA >= 5");
            students.ForEach(x =>
            {
                if (x.Gpa >= 5)
                {
                    Console.WriteLine(x);
                }
            });
            //Java giống C#
            Console.WriteLine("====================================================");
            //giỏ tủ sẽ add sv thỏa check var vào list và return list cho mình
            Console.WriteLine("The list of student with YOB < 2000");
            List<Student> result = students.Where(CheckVar).ToList();
            students.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("In Theo định luật bắt cầu");
            students.Where(CheckVar).ToList().ForEach(x => Console.WriteLine(x));
            //In ra danh sách sinh viên mà có năm sinh lớn hơn hoặc bằng hai k
            Console.WriteLine("In ra danh sách sinh viên mà có năm sinh lớn hơn hoặc bằng hai k");
            students.Where(x => x.Yob >= 2000).ToList().ForEach(x => Console.WriteLine(x));

        }
        public static bool CheckVar(Student x)
        {
            //bạn muốn check gì thì ghi vào đây là sv 
            if (x.Yob < 2000)
            {
                return true;
            }
            return false; //check var sv nào < 2000
        }

        public static void ShowStudent(Student x)
        {
            Console.WriteLine(x);
        }
    }
}