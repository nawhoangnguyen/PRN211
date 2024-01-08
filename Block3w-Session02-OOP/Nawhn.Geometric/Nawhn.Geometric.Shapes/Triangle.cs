using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nawhn.Geometric._2DShapes
{
    internal class Triangle : Shape
    {
        public double EdgeA { get; set; }
        public double EdgeB { get; set; }

        public double EdgeC { get; set; }
        public Triangle(string name, string color, double edgeA, double edgeB, double edgeC) : base(name, color)
        {
            EdgeA = edgeA;
            EdgeB = edgeB;
            EdgeC = edgeC;
        }

        public override double GetArea()
        {
            var p = (EdgeA + EdgeB + EdgeC) / 2;
            return Math.Sqrt(p * (p - EdgeA) * (p - EdgeB) * (p - EdgeC));
        }

        public override void ShowArea()
        {
            Console.WriteLine($"Area of Triangle {Name}: " + GetArea());
        }
    }
}
