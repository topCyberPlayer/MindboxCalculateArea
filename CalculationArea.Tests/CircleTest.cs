using CalculationArea.Shapes;

namespace CalculationArea.Tests
{
    public class CircleTest
    {
        [Theory]
        [InlineData(3.75, 44.1786)]
        [InlineData(6, 113.0973)]
        [InlineData(double.MaxValue, double.PositiveInfinity)]
        public void CalculateAreaTest(double radius, double expected)
        {
            Circle circle1 = Circle.CreateCircle(radius);
            double actual = ShapeCalculator.CalculateArea(circle1);
            double roundedActual = Math.Round(actual,4);
            Assert.Equal(expected, roundedActual);
        }

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(-2)]
        [InlineData(0)]
        public void ThrowsExceptionIfRadiusLessOrEqualZero(double radius)
        {
            var ex = Assert.Throws<ArgumentException>(() => Circle.CreateCircle(radius));
        }
    }
}