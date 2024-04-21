namespace CalculationArea.Shapes
{
    public struct Circle : IShape
    {
        private double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть положительным числом.");

            _radius = radius;
        }

        public double CalculateArea() => Math.PI * _radius * _radius;
    }
}
