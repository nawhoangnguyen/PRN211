using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Nawhn.DataType.DelegateAdvance
{
    internal class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob{ get; set; }

        public double Gpa { get; set; }
        public void SayHello() => Console.WriteLine("Hey, my name is " + Name);

        public static void SayMath() => Console.WriteLine("I got shot like he got shot now he in fking heaven");
    }
}
