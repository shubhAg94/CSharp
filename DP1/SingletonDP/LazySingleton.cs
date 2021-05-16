using System;

namespace SingletonDP
{
    //Lazy Initialization: The lazy initialization of an object improves the performance and avoids unnecessary computation till 
    //the point the object is accessed. Further, it reduces the memory footprint during the startup of the program. 
    //Reducing the memory print will help faster loading of the application.

    //When you have an object that is expensive to create, and the program might not use it.
    //If the user never asks to display the Orders or use the data in a computation, then there is no reason to 
    //use system memory or computing cycles to create it. By using Lazy<Orders> to declare the Orders object for 
    //lazy initialization, you can avoid wasting system resources when the object is not used.

    //Non-Lazy or Eager Loading : Eager loading is nothing but to initialize the required object before it’s being accessed. 
    //Which means, we instantiate the object and keep it ready and use it when we need it.This type of initialization is used 
    //in lower memory footprints. Also, in eager loading, the common language runtime takes care of the variable initialization 
    //and its thread safety. Hence, we don’t need to write any explicit coding for thread safety. 
    public class LazySingleton
    {
        private static int counter = 0;

        private LazySingleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        //Lazy keyword provides support for lazy initialization. In order to make a property as lazy, 
        //we need to pass the type of object to the lazy keyword which is being lazily initialized.

        //By default, Lazy<T> objects are thread-safe.  In multi-threaded scenarios, 
        //the first thread which tries to access the Value property of the lazy object will take care of 
        //thread safety when multiple threads are trying to access the Get Instance at the same time. 
        private static readonly Lazy<LazySingleton> instance = new Lazy<LazySingleton>(() => new LazySingleton());

        public static LazySingleton GetInstance
        {
            get
            {
                //After the Lazy object is created, no instance of Orders is created until the Value property of the 
                //Lazy variable is accessed for the first time. On first access, the wrapped type is created and returned, 
                //and stored for any future access.
                return instance.Value;

                //In multi-threaded scenarios, the first thread to access the Value property of a thread-safe Lazy<T> 
                //object initializes it for all subsequent accesses on all threads, and all threads share the same data. 
                //Therefore, it does not matter which thread initializes the object, and race conditions are benign.
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
