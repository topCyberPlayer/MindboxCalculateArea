using CalculationArea.Shapes;

namespace CalculationArea
{
    public static class ShapeCalculator
    {
        public static double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}