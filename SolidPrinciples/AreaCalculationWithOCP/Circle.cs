using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculationWithOCP
{
    public class Circle : Shape
    {
        private double _radius;
        public double Radius { get { return _radius; } }

        public Circle(double Radius)
        {
            _radius = Radius;
        }
        public override double Area()
        {
            return _radius * _radius * Math.PI;
        }
    }
}
