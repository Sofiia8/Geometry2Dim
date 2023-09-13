using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaLibrary
{
    /// <summary>
    /// Класс, характеризаующий треугольник по 3 его сторонам
    /// </summary>
    public class Triangle3S : IGeometryFigure
    {
        private double _sideA;
        public double SideA
        {
            get { return _sideA; }
            set { if (!double.IsNormal(value) || value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                _sideA = value;
            }
        }
        private double _sideB;
        public double SideB
        { 
            get { return _sideB; }
            set {
                if (!double.IsNormal(value) || value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                _sideB = value;
            }
        }
        private double _sideC;
        public double SideC
        {
            get { return _sideC; }
            set
            {
                if (!double.IsNormal(value) || value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                _sideC = value;
            }
        }
        public Triangle3S(double a, double b, double c) 
        {
            SideA = a; SideB = b; SideC = c;
        }
        public double GetArea()
        {
            double p = (SideA + SideB + SideC) / 2;
            double S = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            return S;
        }
        public bool IsRightTriangle
        {
            get
            {
                if (Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2)) == SideC ||
                    Math.Sqrt(Math.Pow(SideB, 2) + Math.Pow(SideC, 2)) == SideA ||
                    Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideC, 2)) == SideB)
                    return true;
                else
                    return false;
            }
        }
    }
}
