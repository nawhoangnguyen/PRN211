using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nawhn.Runner.DeathRacer
{
    internal class Student : Racer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }
        
        public Student()
        {
        }

        public void DoQuiz()
        {
            Console.WriteLine("Hey proctor, I'm doing quiz " +
                "              PRN211 quiz by th way i'm using" +
                "              source also (quizlet.com)");
        }
        public double RunToDeath()
        {
            return Random.Shared.NextDouble() * 100;
        }

        public string ShowRecord()
        {
            return Name + " speed " + RunToDeath();
        }
    }
}
