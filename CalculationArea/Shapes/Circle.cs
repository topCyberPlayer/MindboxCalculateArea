namespace CalculationArea.Shapes
{
    public readonly struct Circle : IShape
    {
        private readonly double _radius;

        public static Circle CreateCircle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть положительным числом.");

            return new Circle(radius);
        }

        private Circle(double radius) => _radius = radius;

        public readonly double CalculateArea() => Math.PI * _radius * _radius;
    }
}
