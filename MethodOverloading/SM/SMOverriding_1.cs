using System;
using System.Collections.Generic;
using System.Text;

namespace SM
{
    class Base1
    {
        public virtual int M1(int a)
        {
            return a;
        }
    }
    class Child1 : Base1
    {
        public override int M1(int a)
        {
            return a;
        }

        //If this is available than above one will not be called with Child1 object, Wether below method is float or double(If we call child1.M1(5) then also below one only be called)
        public double M1(double d)
        {
            return d;
        }
        public string M1(string d)
        {
            return d;
        }
    }
}
