using System;

namespace Nawhn.LinqIntro.CabinetV2
{
    public class MyIntegerList
    {
        private static int[] _list = { -100, -5, -3, -2, -1, 0, 10, 30, 20, 25, 30, 25, 49, 45 };
        //cung cấp hàm tính tổng style độ theo nhu cầu đáp ứng mọi nhu cầu - DI Dependency Injection

        public static void Sum(Func<int, bool> f) // = hàm CheckNum Bên ngoài (nhận vào con num )
        {
            int sum = 0;
            for (int i = 0; i < _list.Length; i++)
            {
                if (f(_list[i]) == true)
                {
                    sum += _list[i];
                } //thì sẽ dùng để tính tỏng, nhưng có đúng là x cần tính tổng ay ko
                  //Ta đi hỏi hàm F(x), do bên ngoài đưa vào, trả về true/false
                  //theo nhu cầu bên ngoài
            }

            //in tổng hoặc return tổng là tính con số [i] đã đc check var bởi hàm f bên ngoài.
            Console.WriteLine("The sum: " + sum);
        }

        //TA CHẾ THÊM 1 HÀM, LỌC RA HAY LÀ ÍNH CON SỐ THEO YÊU CẦU
        //THỎA CHECK VAR
        //HÀM NÀY IN RA TỔNG SỐ CHẴN LẺ > 0
        //HÀM NÀY IN RA SỐ CHẴN LẺ > 0


        //Bên Java: cái thằng/class/thùng chứa 1 đống dữ liệu đơn giản nhất gọi là ArrayLisst????
        //tương đương ArrayList bên C# sẽ lẽ List<?????>

        public static List<int> Where(Func<int, bool> f)
        {
            //có được quét hết mảng, lôi từng đứa [i] ra, hỏi check var thỏa ko, thỏa, cất vào
            List<int> result = new();        //new viết tắ, cx xài generic
            for (int i = 0; i < _list.Length; i++)
            {
                //lôi từng value của amngr, hỏi check vả ổn ko, ổn cho vào list
                if (f(_list[i]) == true) 
                {
                    result.Add(_list[i]);
                }
            }
            return result;
        }

    } //hàm f gọi là hàm chẹc var nó check thế nào thì tổng như thế
    //check số > 0 thì là tổng của số > 0
    //check số lẻ thì là tổng lẻ
    //check nguyên tố thì là tổng nguyên tố

    internal class Program
    {
        static void Main(string[] args)
        {
            //chơi hàm Where trả về ArrayList theo nhu cầu
            //cứ angkara đưa vào qua ngả angkara,keej tía má nó, chấp nhạn hếtm return true
            //Lấy hết cả mảng vì trong Where và for tứng con số, đưa check var, chec var okie hết            
            List<int> r = MyIntegerList.Where(delegate (int angkara) { return true; });
            foreach (var item in r)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            List<int> r2 = MyIntegerList.Where(x =>
            {
                if (x < 5)
                {
                    return true;
                }
                return false;
            });
            foreach (var x in r2)
            {
                Console.Write(x + " ");
            }

        }
        //static void Main(string[] args)
        //{
        //    MyIntegerList.Sum(CheckVarNum);
        //    Console.WriteLine("==============================");
        //    Console.WriteLine("Using callback");
        //    //tính tổng tất cả các con số
        //    MyIntegerList.Sum((num) =>
        //    {
        //        return true;
        //    });
        //    //tính tổng tất cả các con số âm
        //    MyIntegerList.Sum((num) =>
        //    {
        //        if (num < 0)
        //        {
        //            return true;
        //        }
        //        return false;
        //    });

        //    MyIntegerList.Sum((num) =>
        //    {
        //        if (num < 0)
        //        {
        //            return true;
        //        }
        //        return false;
        //    });
        //    Console.WriteLine("==============================");

        //}
        //chơi hàm lẻ thử, check var thử
        public static bool CheckVarNum(int num)
        {
            //if tùy minh muốn check num như thế nào
            if (num > 0 && num % 2 == 0)
                return true;

            return false;
        }
    }
}