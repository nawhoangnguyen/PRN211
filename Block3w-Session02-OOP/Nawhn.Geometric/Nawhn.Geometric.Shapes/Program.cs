using Nawhn.Geometric._2DShapes;
using System.Diagnostics;

namespace Nawhn.Geometric.Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //gọi một hàm cha ba thằng con chạy theo
            //phải khai báo cha, cha chạy override
            Shape[] list = new Shape[6];
            list[0] = new Disk("D1", "Pink", 3);
            list[1] = new Disk("D2", "Black", 9);
            list[2] = new Rectangle("R2", "Blue", 3, 4);
            list[3] = new Rectangle("R3", "Yellow", 4, 5);
            list[4] = new Triangle("T4", "Brown", 3, 4, 5);
            list[5] = new Triangle("T4", "Green", 6, 8, 10);
            Console.WriteLine("Descending by area");
            for (int i = 0; i < list.Length - 1; i++)
            {
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[i].GetArea() > list[j].GetArea())
                    {
                        var temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }

            }

            foreach (var item in list)
            {
                item.ShowArea();
            }

            Stopwatch sw = Stopwatch.StartNew();
            sw.Stop();
            Console.WriteLine("Time taken: {0}ms", sw.Elapsed.TotalMilliseconds);


        }

    }
}