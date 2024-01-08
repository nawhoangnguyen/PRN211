using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nawhn.FAP.StudentManagerV10
{
    internal  class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }        
        public Person(string id, string name, int yob)
        {
            Id = id;
            Name = name;
            Yob = yob;
        }
        public virtual void ShowProfile()
        {
            Console.WriteLine("{0} {1} {2}", Id, Name, Yob);
        }
    }
}
