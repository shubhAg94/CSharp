using System;

namespace SingletonDP
{
    public sealed class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton instance = null;
        private static int counter = 0;
        private static readonly object lockObject = new object();

        private ThreadSafeSingleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        public static ThreadSafeSingleton GetInstance
        {
            get
            {
                //The problem is that our lock object code will be called everytime the property of SingleInstance is accessed 
                //which may incur a huge performance cost on application as locks are quite expensive when we want good performance
                //in our application. So, we can restrict this every time lock code access by wrapping is under the condition.
                //that it could only be accessed if singleInstance backing field is null. 

                //Now when we run the application, the lock code would not be executed every time but only for the first time 
                //when it is accessed because at the second time it will not find the singleInstance field as null.
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        //if (instance == null)
                        //{
                            instance = new ThreadSafeSingleton();
                        //}
                    }
                }
                return instance;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
