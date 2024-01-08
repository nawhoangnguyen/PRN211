namespace Nawhn.DataType.DelegateAdvanceV2
{
    public delegate double F(int a, double b);
    //F là đại diện cho 1 nhóm các hàm
    //có style là int tên hàm (int, double) 
    //hàm nào cứ có style này thuộc nhà F
    //ta sẽ nói về 1 hàm nào đó cụ thể, gọi là r = hàm nào đó doán xem
    internal class Program
    {
        static void Main(string[] args)
        {
            //F x = hàm nào đó có style int(int double);
            //F x = ???
            Sum(2, 3);
            F x = Sum;
            Console.WriteLine("10 + 3.14 = " + x(10, 3.14));
            Console.WriteLine(Multiply(2, 3));
            //CHƠI ANONYMOUS VÀ LAMBDA
            F ahihi = delegate (int a, double b)
            {
                return Math.Pow(a, b);
            };
            Console.WriteLine("10 ^ 2 = " + ahihi(10, 2));
            //LAMBDA
            Console.WriteLine("==================");
            ahihi = (a, b) => Math.Pow(a, b);
            Console.WriteLine("10 ^ 3 = " + ahihi(10, 3));

            //HÃY VIẾT BẰNG LAMBDA HÀM NHẬN VÀO 2 CÓN SỐ x, y
            //ko dùng phép nhân
            //ví dụ: x = 10 y = 3 nghãi là tính tổng của 10 lần con số 3
            ahihi = (a, b) =>
            {
                double sum = 0;
                for (int i = 0; i < b; i++)
                {
                    sum += a;
                }
                return sum;
            };
            Console.WriteLine("Your result " + ahihi(5, 20));
        }

        public static double Sum(int a, double b)
        {
            //hàm này vô hai con số trả về hai con số
            return a + b;
        }

        public static double Multiply(int c, double d)
        {
            //hàm này vô hai con số trả về hai con số
            return c * d;
        }
    }
}

