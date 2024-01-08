namespace Nawhn.FAP.StudentManagerV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("17204", "NamNH", "NAM@gmail.com", "0898878931", "HCM");
            Console.WriteLine(s1.ToString());

            //hỏi riêng phone của thằng object
            Console.WriteLine($"Phone number cua object: {s1.Phone}");

            //set phone thằng object đó
            s1.Phone = "0898878932";
            Console.WriteLine($"Phone number cua object after calling set: {s1.Phone}");
        }
    }
}