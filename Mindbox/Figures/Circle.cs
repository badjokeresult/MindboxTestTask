using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.Figures
{
    public class Circle : IFigure
    {
        private double Radius { get; set; }

        public Circle(double Radius)
        {
            if (Radius < 0)
                throw new ArgumentOutOfRangeException("Radius of a circle cannot be negative");
            this.Radius = Radius;
        }

        public double Square()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return Radius.ToString();
        }
    }
}
