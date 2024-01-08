using Nawhn.LinqIntro.StudentMgt;

namespace Nawhn.LinqIntro.CabinetV1
{
    public class MyIntegerList
    {
        //đây là một cái hộp chứa sẵn bên trong rất nhiều con số và ta sẽ
        //cung cấp dịch vụ ra bên ngoài
        //in các dãy số theo nhu cầu của bên ngoài
        private static int[] _list = { -100, -5, -3, -2, -1, 5, 10, 15, 20, 25, 30, 25, 49, 45 };
        //tui mún làm hàm cung cấp dịch vụ về con số cho ai đó cần
        //2 style thiết kê, ta tức là class này tự cung cấp ra một laotj các hàm nào đó
        //VD: hàm in số âm, hàm in số dươg,hàm in số chẵn, hàm in số lẻ, hàm in số chia hết cho 5, hàm tính tổng, hàm đếm số chẵn, hàm.... vô số kể
        //STYLE 01
        public static void PrintEvenNumber()
        {
            Console.WriteLine("The list of even number in Array");
            for (int i = 0; i < _list.Length; i++)
            {
                if (_list[i] > 0 && _list[i] % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        //VÔ SỐ HÀM NHƯ THẾ NÀY MÀ TA - TÁC GIẢ CLASS PHẢI VIẾT, PHẢI CUNG CẤP
        //CHO USER XÀI CÁCH NÀY DỞ VÌ KO ĐOÁN HẾT ĐC NHU CẦU CỦA AI ĐÓ SẼ XÀI CLASS NÀY CỦA TA
        //BAO NHIÊU NHU CẦU THÌ BẤY NHIÊU HÀM, TA THÌ KO ĐOÁN ĐC HẾT NHU CẦU
        //TA TỰ CUNG CẤP


        //STYLE 02
        //MÀY MUỐN GÌ NÓI ĐI TAO FILTER, TÍNH TOÁN CHO KO CẦN DỰ ĐOÁN
        //ĐÚNG STYLE PHỤC VỤ -> NGOÀI ĐỜI A ƠI EM ĂN PHỞ NƯỚC TRONG KO HÀNH
        public static void PrintOnDemands(Action<int> f)
        {
            //f sẽ phải bằng một hàm void fxxxx(int x) {......}
            foreach (var x in _list)
            {
                f(x);
                // tui có rất nhiều số nguyên gọi nó là x cho hàm ở xa mún làm gì làm                
            }
        }

    }


    internal class Program
    {
        //kiểm tra một số chia hết cho 5 hay ko, đúng thì in ra
        public static void PrintMod5(int n)
        {
            if (n > 0 && n % 5 == 0)
            {
                Console.WriteLine(n);
            }

        }
        static void Main(string[] args)
        {
            MyIntegerList.PrintOnDemands(PrintEven);
            Console.WriteLine("============");
            Console.WriteLine("lambda");
            MyIntegerList.PrintOnDemands((x) =>
            {
                if (x > 0 && x % 2 != 0)
                {
                    Console.WriteLine(x);
                }
            });            
            Console.WriteLine("============");
            Console.WriteLine("chia het cho 5 delegate");
            MyIntegerList.PrintOnDemands(delegate (int n)
            {
                if (n > 0 && n % 5 == 0)
                {
                    Console.WriteLine(n);
                }


            });
            Console.WriteLine("Các số chia hết cho 5");
            MyIntegerList.PrintOnDemands((n) =>
            {
                if (n > 0 && n % 5 == 0)
                {
                    Console.WriteLine(n);
                }


            });
        }
        //viết hàm lẻ trước khi xài lamda
        public static void PrintEven(int n)
        {
            if (n > 0 && n % 2 == 0)
            {
                Console.WriteLine(n);
            }
        }
    }
}
