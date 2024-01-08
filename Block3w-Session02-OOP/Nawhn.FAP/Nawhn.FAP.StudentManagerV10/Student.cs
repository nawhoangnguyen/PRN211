using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nawhn.FAP.StudentManagerV10
{
    internal class Student :Person
    {    
        public double Gpa;
        public Student(string id, string name, int yob, double gpa) : base(id, name, yob)
        {
            Gpa = gpa;
        }
        public override void ShowProfile()
        {
            Console.WriteLine("|{0}     {1}        {2}     {3}|", Id, Name, Yob, Gpa);
        }
    }
}
