using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaLibrary
{
    public class Circle : IGeometryFigure
    {
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set { if (!double.IsNormal(value) || value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                else
                    _radius = value;
            }
        }
        public Circle(double r)
        {
            Radius = r;
        }
        public double GetArea()
        {
            return Math.PI*Math.Pow(_radius,2);
        }
    }
}
