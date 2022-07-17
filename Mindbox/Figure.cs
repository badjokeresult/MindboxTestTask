using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mindbox.Figures;

namespace Mindbox
{
    public class Figure
    {
        public readonly IFigure figure;

        public Figure(IFigure figure)
        {
            this.figure = figure;
        }

        public double Square()
        {
            return figure.Square();
        }

        public bool IsRectangular()
        {
            if (figure is Triangle)
                return (figure as Triangle).IsRectangular();
            return false;
        }

        public override string ToString()
        {
            return figure.ToString();
        }
    }
}
