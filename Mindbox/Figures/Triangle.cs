using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.Figures
{
    public class Triangle : IFigure
    {
        private double A { get; set; }  
        private double B { get; set; }
        private double C { get; set; }


        public Triangle(double A, double B, double C)
        {
            if (A < 0 || B < 0 || C < 0)
                throw new ArgumentOutOfRangeException("Side of a triangle cannot be negative");
            if (A + B < C || B + C < A || A + C < B)
                throw new ArgumentOutOfRangeException("Sum of two sides of a triangle cannot be less than the third one");
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public double Square()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool IsRectangular()
        {
            return (A * A == B * B + C * C) || (B * B == A * A + C * C) || (C * C == A * A + B * B);
        }

        public override string ToString()
        {
            return $"{A}, {B}, {C}";
        }
    }
}
