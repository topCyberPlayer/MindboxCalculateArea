namespace CalculationArea.Shapes
{
    public struct Triangle : IShape
    {
        private double _side1, _side2, _side3;

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException("Все стороны треугольника должны быть положительными числами.");

            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public double CalculateArea()
        {
            double semiPerimeter = (_side1 + _side2 + _side3) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - _side1) * (semiPerimeter - _side2) * (semiPerimeter - _side3));
        }

        public bool IsRightAngleTriangle()
        {
            double[] sides = { _side1, _side2, _side3 };
            Array.Sort(sides);
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}
