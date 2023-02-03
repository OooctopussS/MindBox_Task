using MindBoxTask_HH;

namespace FigureTest
{
    [TestClass]
    public class FigureSquareTest
    {
        [TestMethod]
        public void Triangle_WithValidValue_GetSquare()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6.0;

            IFigure figure = new Triangle(a, b, c);

            var square = figure.GetSquare();

            Assert.AreEqual(expected, square, 0.001, "Площадь треугольника посчитана неправильно");
        }

        [TestMethod]
        public void Circle_WithValidValue_GetSquare()
        {
            double a = 3;
            double expected = 28.0;

            IFigure figure = new Circle(a);

            var square = figure.GetSquare();

            Assert.AreEqual(expected, square, 0.001, "Площадь круга посчитана неправильно");
        }

        [TestMethod]
        public void Triangle_IsRightTriangle()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            bool expected = true;

            Triangle figure = new (a, b, c);

            bool result = figure.IsRightTriangle();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Triangle_WhenSideNegativeValue()
        {
            double a = -3;
            double b = 4;
            double c = 4;

            Assert.ThrowsException<System.ArgumentException>(() => new Triangle(a, b, c));
        }

        [TestMethod]
        public void Circle_WhenSideNegativeValue()
        {
            double a = -3;

            Assert.ThrowsException<System.ArgumentException>(() => new Circle(a));
        }

        [TestMethod]
        public void Triangle_InvalidTriangle()
        {
            double a = 5;
            double b = 555;
            double c = 4;

            Assert.ThrowsException<System.ArgumentException>(() => new Triangle(a, b, c));
        }
    }
}