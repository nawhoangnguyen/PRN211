using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nawhn.Geometric._2DShapes
{
    internal class Disk : Shape
    {
        public double Radius { get; set; }
        public Disk(string name, string color, double radius) : base(name, color)
        {
            Radius = radius;
        }



        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override void ShowArea()
        {
            Console.WriteLine($"Area of Disk {Name}: " + GetArea());
        }
    }
}
