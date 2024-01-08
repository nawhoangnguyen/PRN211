namespace Nawhn.LinqIntro.StudentMgt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student() { Id = "SE1", Name = "CR7", Gpa = 115, Yob = 2003 };

            s.SayHello("Merry Christmas 2024!!!!");

            //bắt sv in bảng cửu chương
            //Action f = PrintMultiplicationTable
            s.DoSomethingInFuture(PrintMultiplication);// cần 1 hàm void ở đâu đó đưa vào đây
            Console.WriteLine("===========================================");
            Console.WriteLine("The list of 1st integer from 1 to 100");
            s.DoSomethingInFuture(() =>
            {
                int sum = 0;
                for (int i = 0; i <= 100; i++)
                {
                    Console.Write(i + " ");
                    sum += i;
                }
                Console.WriteLine("\nTotal: " + sum);
            });
            //bắt sv in ra các số từu 1 ... 100 và tổng của chung
        }
        static void PrintMultiplication()
        {
            Console.WriteLine("Bang 9 chapter 2");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"2 * {i} = " + (i * 2));
            }
        }

    }
}