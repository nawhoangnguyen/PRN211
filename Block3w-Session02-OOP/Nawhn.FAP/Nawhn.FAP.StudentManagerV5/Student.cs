using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nawhn.FAP.StudentManagerV5
{
    internal class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }
        public override string? ToString()
        {
            return @$"Student profile   
                                           Id : {Id} 
                                         Name : {Name}";
        }
    }
}
