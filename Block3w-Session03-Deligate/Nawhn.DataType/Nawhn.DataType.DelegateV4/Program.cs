namespace Nawhn.DataType.DelegateV4
{
    public delegate void SayXXX();
    internal class Program
    {
        static void Main(string[] args)
        {
            SayXXX f = () => { Console.WriteLine(args);
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine( i);
                    i++;
                }
            };
            f();
        }

        public static void Print()
        {

        }
    }


}