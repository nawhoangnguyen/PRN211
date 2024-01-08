using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Nawhn.FAP.StudentManagerV9
{
    /// <summary>
    /// Class này chứa các hàm là công cụ xử lí dùng chung cho mọi nơi
    /// vì là để xài chung nên nó sẽ là static, chấm xài trực tiếp mà hok cần neww
    /// Muốn new thì cũng chỉ có 1 vùng RAM chứa đồ static mà thôi
    /// 
    /// </summary>
    internal class MyToys
    {
        /// <summary>
        /// hàm này sẽ tính n! = 1,2,3,....n trong đó 0! = 1! =1
        /// ko có giai thừa của số âm, tối đa 20! vì 21! tràn kiểu long
        /// </summary>
        /// <param name="n">n nằm từ 0...20</param>
        /// <returns>n! = 1,2,3,....n</returns>
        public static long ComputeFactorial(int n)
        {
            if (n < 0 || n > 20)
            {
                throw new ArgumentOutOfRangeException("number must between 0-20");

            }            
            if (n == 1)
                return 1;
            else
                return n * ComputeFactorial(n - 1);
        }

    }
}
