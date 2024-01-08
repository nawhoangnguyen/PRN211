using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nawhn.FAP.StudentManagerV10
{
    internal class Lecturer:Person
    {
        public double Salary;
        public Lecturer(string id, string name, int yob, double salary) : base(id, name, yob)
        {
            Salary = salary;
        }
        public override void ShowProfile()
        {
            Console.WriteLine("|{0}     {1}        {2}     {3}|", Id, Name, Yob, Salary);
        }
    }
}
