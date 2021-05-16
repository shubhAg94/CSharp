using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculationWithOCP
{
    public class Rectangle : Shape
    {

        //Instead of properties we can use Constructor also to set values of width and height like other two classes Circus and Triangle
        //https://www.codeproject.com/Articles/613119/SOLID-Principles-The-Open-Closed-Principle-What-Wh
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }
    }
}
