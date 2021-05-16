using System;

namespace SingletonDP
{
    //Need of sealed keyword
    public class Singleton
    {
        private static Singleton instance = null;
        private static int counter = 0;
        private static object obj = new object();

        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        //By removing sealed keyword we can inherit the singleton class and instantiate multiple objects 
        //This violates singleton design principles.
        //Because before execution of DerivedSingleton class constructor, base class(Singleton) ctor will be called,
        //and here that is accessible to DerivedSingleton class constructor.
        public class DerivedSingleton : Singleton
        {
            public DerivedSingleton()
            {

            }
        }
    }
}
