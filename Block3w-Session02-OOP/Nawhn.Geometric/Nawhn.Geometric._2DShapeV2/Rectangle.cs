using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nawhn.Geometric._2DShapeV2
{
    internal class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Rectangle(string name, string color, double height, double width) : base(name, color)
        {
            Height = height;
            Width = width;
        }

        public override double Area => Width * Height;
    }
}
