using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationArea.Shapes
{
    public struct Circle : IShape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculateArea()
        {
            if (_radius <= 0)
                throw new ArgumentException("Радиус должен быть положительным числом.");

            return Math.PI * _radius * _radius;
        }
    }
}
