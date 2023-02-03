namespace MindBoxTask_HH
{
    public class Circle : IFigure
    {
        public string Name => "Circle";
        public double Radius { get; private set; }


        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус не может быть отрциательным числом.");
            }

            Radius = radius;
        }

        public double GetSquare()
        {
            return Math.Round(Math.PI * Radius * Radius);
        }
    }
       
    public class Triangle : IFigure
    {
        public string Name => "Triangle";
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentException("Сторона не может быть отрицательным числом.");
            }

            if (((a + b) < c) || ((b + c) < a) || ((a + c) < b))
            {
                throw new ArgumentException("Сторона треугольнка больше суммы двух других.");
            }

            SideA = a;
            SideB = b;
            SideC = c;
        }

        public double GetSquare()
        {
            var p = (SideA + SideB + SideC) / 2;

            var square = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));

            return Math.Round(square);
                
        }

        public bool IsRightTriangle()
        {
            bool result = (SideA * SideA == SideB * SideB + SideC * SideC
                        || SideB * SideB == SideA * SideA + SideC * SideC
                        || SideC * SideC == SideA * SideA + SideB * SideB);

            return result;
        }
    }

}