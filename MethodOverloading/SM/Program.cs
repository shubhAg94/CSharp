using System;

namespace SM
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Overriding Examples
            //Base1 b1 = new Child1();
            //b1.M1(5);

            //from base reference we can call only the methods present in base class, 
            //While runtime it will check underline object and call child method.
            //b1.M1(5.01212);

            //Child1 c = new Child1();
            //c.M1(5);
            //c.M1(123.00);
            //c.M1("Shubham");

            //Base2 b2 = new Child3();
            //b2.M1(5);

            //Base3 b3 = new C2();
            //b3.M1(5);

            //Base4 b4 = new CC2();
            //b4.M1(4);

            //CC1 obj = new CC1();
            //obj.M1(4);

            //CC1 obj1 = new CC2(); //TODO : NEED to check
            //obj1.M1(3);
            //obj1.M1(3, 5);
            #endregion Overriding Examples

            #region Overloading Examples

            //SM3 sm3 = new SM3();
            //SM3.M1(5);
            //SM3.M1(5, 10);
            //SM3.M1(5, 10.00);

            //SM5.M1(4); //Compile time error this call become ambigous b/c in both method one param is required and others are optional
            //SM5.M1(3,6);

            //SM6.M1(4, 3);

            #endregion Overloading Examples

            Console.ReadKey();
        }
    }
}
