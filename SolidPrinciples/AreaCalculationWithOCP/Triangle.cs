using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculationWithOCP
{
    public class Triangle : Shape
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        //public double FirstSide { get { return _firstSide; } }
        //public double SecondSide { get { return _secondSide; } }
        //public double ThirdSide { get { return _thirdSide; } }

        public Triangle(double FirstSide, double SecondSide, double ThirdSide)
        {
            _firstSide = FirstSide;
            _secondSide = SecondSide;
            _thirdSide = ThirdSide;
        }

        public override double Area()
        {
            double TotalHalf = (_firstSide + _secondSide + _thirdSide) / 2;
            return Math.Sqrt(TotalHalf * (TotalHalf - _firstSide) *
                            (TotalHalf - _secondSide) * (TotalHalf - _thirdSide));
        }
    }
}
