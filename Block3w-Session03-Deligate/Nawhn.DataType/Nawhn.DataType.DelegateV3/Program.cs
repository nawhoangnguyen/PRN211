namespace Nawhn.DataType.DelegateV3
{
    public delegate void SayXXX();
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintIntegerList();
            //SayXXX f = PrintIntegerList;
            //f.Invoke();

            SayXXX f = delegate
            {
                int count = 1;
                do
                {
                    Console.Write(count);
                    count++;
                } while (count <= 100);
            };
            f();

            Console.WriteLine("=============================");
            SayXXX f2 = () => {             
                int count = 1;
                do
                {
                    Console.Write(count);
                    count++;
                } while (count <= 100);
            };
            f2();
        }
        public static void PrintIntegerList()
        {
            int count = 1;
            do
            {
                Console.Write(count);
                count++;
            } while (count <= 100);
        }
    }
}