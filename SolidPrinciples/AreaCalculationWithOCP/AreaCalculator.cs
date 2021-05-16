using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculationWithOCP
{
    //http://joelabrahamsson.com/a-simple-example-of-the-openclosed-principle/
    //https://www.codeproject.com/Articles/613119/SOLID-Principles-The-Open-Closed-Principle-What-Wh
    public class AreaCalculator
    {
        public double Area(Shape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }

            return area;
        }
    }

    interface IA
    {
        void M1();
    }
    public abstract class A
    {
        
    }
}
