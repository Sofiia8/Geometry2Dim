using FigureAreaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CircleArea_3()
        {
            double radius = 3;
            double expected = Math.PI*9;
            Circle circle = new Circle(radius);
            double actual = circle.GetArea();
            Assert.AreEqual(expected, actual);
        }
    }
}
