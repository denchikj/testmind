using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfShapes
{
    public class Triangle : Shape
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;

        public Triangle(double a, double b, double c)
        {
            ValidateSides(a, b, c);

            this.a = a;
            this.b = b;
            this.c = c;
        }

        private void ValidateSides(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException(nameof(a), nameof(b), nameof(c));
            //throw new ArgumentException("Ни одна из сторон треугольника не может быть меньше или равна нулю");

            if (a + b <= c || b + c <= a || c + a <= b)
                throw new ArgumentOutOfRangeException("Сторона треугольника не может быть меньше суммы двух других сторон");
        }

        public override double GetArea()
        {
            var s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public bool IsRightAngled()
        {
            return a * a + b * b == c * c || b * b + c * c == a * a || c * c + a * a == b * b;
        }
    }
}
