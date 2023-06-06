using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfShapes
{
    public class Circle : Shape
    {
        private readonly double radius;
        public Circle(double radius) 
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(radius));
            }

            this.radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
