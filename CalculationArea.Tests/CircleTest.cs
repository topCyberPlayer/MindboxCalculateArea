using CalculationArea.Shapes;

namespace CalculationArea.Tests
{
    public class CircleTest
    {

        [Theory]
        [InlineData(0, 0)]
        [InlineData(3.75, 5)]
        public void Test1(double radius, double expected)
        {
            Circle circle = new(radius);
            double actual = ShapeCalculator.CalculateArea(circle);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ThrowsException()
        {
            double radius = -2;
            Circle circle = new(radius);
            var ex = Assert.Throws<ArgumentException>(() => ShapeCalculator.CalculateArea(circle));
        }
    }
}