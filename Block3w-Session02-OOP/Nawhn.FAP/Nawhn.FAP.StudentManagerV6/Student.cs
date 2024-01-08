using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Nawhn.FAP.StudentManagerV6
{
    internal class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Gpa { get; set; }

        public int Yob { get; set; }

        public Student()
        {
        }

        public Student(string id, string name, double gpa, int yob)
        {
            Id = id;
            Name = name;
            Gpa = gpa;
            Yob = yob;
        }

        public override string? ToString()
        {
            return @$"Student profile Id : {Id} Name : {Name} Yob : {Yob}";
        }
    }
}