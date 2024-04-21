using CalculationArea.Shapes;

namespace CalculationArea.Tests
{
    public class TriangleTest
    {
        [Theory]
        [InlineData(1, 1, 1, 0.4330)]
        [InlineData(5, 6, 7, 14.6969)]
        public void CalculateAreaTest(double side1, double side2, double side3, double expected)
        {
            Triangle triangle = new Triangle(side1,side2, side3);
            double actual = ShapeCalculator.CalculateArea(triangle);
            double roundedActual = Math.Round(actual, 4);
            Assert.Equal(expected, roundedActual);
        }

        [Theory]
        [InlineData(7, 24, 25, true)]
        [InlineData(9, 11, 13, false)]
        public void IsRightAngleTriangleTest(double side1, double side2, double side3, bool expected)
        {
            Triangle triangle = new Triangle(side1, side2, side3);
            bool result = triangle.IsRightAngleTriangle();
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(0, 1, 1)]
        public void ThrowsExceptionIfSideLessOrEqualZero(double side1, double side2, double side3)
        {
            var ex = Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));
        }
    }
}
