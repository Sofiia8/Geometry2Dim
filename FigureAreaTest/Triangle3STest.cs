using FigureAreaLibrary;

namespace FigureAreaTest
{
    [TestClass]
    public class Triangle3STest
    {
        [TestMethod]
        public void TriangleArea_3_4_5_returned_6() 
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;
            Triangle3S triangle = new Triangle3S(a, b, c);
            double actual = triangle.GetArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleArea_13_14_15_returned_84() 
        {
            double a = 13;
            double b = 14;
            double c = 15;
            double expected = 84;
            Triangle3S triangle = new Triangle3S(a, b, c);
            double actual = triangle.GetArea();
            Assert.AreEqual(expected, actual);
        }
    }
}