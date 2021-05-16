
using System;

namespace GenericsImplementation
{
    public class GenericClass<T> 
    {
        private T genericVariable;

        public T genericProperty { get; set; }

        public GenericClass(T value)
        {
            genericVariable = value;
        }

        public T GenericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericVariable);

            return genericVariable;
        }

        //public void Test()
        //{
        //    Console.WriteLine("Non generic method in generic class");
        //}

        //public void Test1(int item)
        //{
        //    Console.WriteLine("Non generic method in generic class");
        //}
    }
}
