using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nawhn.FAP.StudentManagerV8
{
    internal class Lecturer

    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Salary { get; set; }

        public Lecturer(string id, string name, int yob, double salary)
        {
            Id = id;
            Name = name;
            Yob = yob;
            Salary = salary;
        }

        public Lecturer()
        {
        }

        public override string? ToString() =>
         $"{Id} | {Name} | {Yob} | {Salary}"; //interpolation
                                           //expression body
    }
}
